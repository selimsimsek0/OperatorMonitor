using FluentAssertions;
using Moq;
using NUnit.Framework;
using OperatorMonitor.Business.CustomExceptions;
using OperatorMonitor.Business.Managers;
using OperatorMonitor.Business.Models;
using OperatorMonitor.Business.Providers;
using System;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.UnitTest
{
    public class AccesLogManagerTest
    {
        [Test]
        public  void GetLog_WithFailStatusCodeAccesLog_ThrowVerificationFailedException()
        {
            #region Arrange
            ServiceResult<AccessLogDto> returnedValue = new ServiceResult<AccessLogDto>
            {
                Message = "Success",
                Response = true,
                Data = new AccessLogDto
                {
                    VerifyStatusCode = 2
                }
            };

            Mock<IOperationLogService> operationLogServiceMoq = new Mock<IOperationLogService>();
            Mock<IAccessLogService> accessLogServiceeMoq = new Mock<IAccessLogService>();
            accessLogServiceeMoq.Setup(p => p.GetOperationLog()).ReturnsAsync(returnedValue);
            AccesLogManager accesLogManager = new AccesLogManager(operationLogServiceMoq.Object, accessLogServiceeMoq.Object);
            #endregion

            #region Action
            Func<Task> getLogAction = async () => { await accesLogManager.GetLog(); };
            #endregion

            #region Assert
            getLogAction.Should().ThrowAsync<VerificationFailedException>();
            #endregion
        }

        [Test]
        public void GetLog_WithFalseResponseServiceResult_ThrowFailedRequestDataException()
        {
            #region Arrange
            ServiceResult<AccessLogDto> returnedValue = new ServiceResult<AccessLogDto>
            {
                Message = "fail",
                Response = false,
                Data = null
            };

            Mock<IOperationLogService> operationLogServiceMoq = new Mock<IOperationLogService>();
            Mock<IAccessLogService> accessLogServiceeMoq = new Mock<IAccessLogService>();
            accessLogServiceeMoq.Setup(p => p.GetOperationLog()).ReturnsAsync(returnedValue);
            AccesLogManager accesLogManager = new AccesLogManager(operationLogServiceMoq.Object, accessLogServiceeMoq.Object);
            #endregion

            #region Action
            Func<Task> getLogAction = async () => { await accesLogManager.GetLog(); };
            #endregion

            #region Assert
            getLogAction.Should().ThrowAsync<FailedRequestDataException>();
            #endregion
        }
    }
}
