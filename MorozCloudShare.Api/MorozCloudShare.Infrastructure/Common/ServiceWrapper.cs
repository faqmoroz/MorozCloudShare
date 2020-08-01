using MorozCloudShare.Core.Common;
using MorozCloudShare.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Infrastructure.Common
{
    /// <summary>
    /// Service workers wrapper for controlling exceptions.
    /// </summary>
    public class ServiceWrapper:IServiceWrapper
    {
        /// <summary>
        /// Exceptions logger.
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// Ctor with DI.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        public ServiceWrapper(ILogger logger)
        {
            logger = _logger;
        }

        /// <summary>
        /// Method for wrapping service actions.
        /// </summary>
        /// <param name="func">Service action.</param>
        /// <returns>Result of service action.</returns>
        public Result WrapAction(Func<Result> func)
        {
            try {
                return func.Invoke();
            }
            catch (CustomException ex)
            {
                _logger.WriteLog(ex.Message, LogType.Warning);
                return new Result()
                {
                    Messsage = ex.Message,
                    ResultStatus = ResultStatus.Error
                };
            }
            catch (Exception ex){
                _logger.WriteLog(ex.Message, LogType.Error);
                return new Result()
                {
                    Messsage = "Oooops, something gone wrong!",
                    ResultStatus = ResultStatus.Error
                };
            }
        }

        /// <summary>
        /// Generic Method for wrapping service actions.
        /// </summary>
        /// <param name="func">Service action.</param>
        /// <returns>Result of service action.</returns>
        public Result<T> WrapAction<T>(Func<Result<T>> func)
        {
            try
            {
                return func.Invoke();
            }
            catch (CustomException ex)
            {
                _logger.WriteLog(ex.Message, LogType.Warning);
                return new Result<T>()
                {
                    Messsage = ex.Message,
                    ResultStatus = ResultStatus.Error
                };
            }
            catch (Exception ex)
            {
                _logger.WriteLog(ex.Message, LogType.Error);
                return new Result<T>()
                {
                    Messsage = "Oooops, something gone wrong!",
                    ResultStatus = ResultStatus.Error
                };
            }
        }
    }
}
