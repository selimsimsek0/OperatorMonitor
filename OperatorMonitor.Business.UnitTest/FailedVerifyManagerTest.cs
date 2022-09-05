using FluentAssertions;
using Moq;
using NUnit.Framework;
using OperatorMonitor.Business.Mail;
using OperatorMonitor.Business.Managers;

namespace OperatorMonitor.Business.UnitTest
{
    public class FailedVerifyManagerTest
    {
        [Test]
        public void CheckOperatorResult_WithGreaterThan30SecondValue_ReturnFalse()
        {
            #region Arrange

            Mock<IAccessLogManager> accessLogManagerMoq = new Mock<IAccessLogManager>();
            Mock<IFailedVerifyMailSender> failedVerifyMailMoq = new Mock<IFailedVerifyMailSender>();
            FailedVerifyManager failedVerifyManager = new FailedVerifyManager(accessLogManagerMoq.Object, failedVerifyMailMoq.Object);
            #endregion

            #region Action
            bool confirmedTrueAction= failedVerifyManager.CheckOperatorResult(35, true);
            bool confirmedFalseAction = failedVerifyManager.CheckOperatorResult(35, false);
            #endregion

            #region Assert
            confirmedTrueAction.Should().BeFalse();
            confirmedFalseAction.Should().BeFalse();
            #endregion
        }

        [Test]
        public void CheckOperatorResult_WithFalseVerifyConfirmed_ReturnFalse()
        {
            #region Arrange

            Mock<IAccessLogManager> accessLogManagerMoq = new Mock<IAccessLogManager>();
            Mock<IFailedVerifyMailSender> failedVerifyMailMoq = new Mock<IFailedVerifyMailSender>();
            FailedVerifyManager failedVerifyManager = new FailedVerifyManager(accessLogManagerMoq.Object, failedVerifyMailMoq.Object);
            #endregion

            #region Action
            bool lessThan30SecondAction= failedVerifyManager.CheckOperatorResult(10, false);
            bool greaterThan30SecondAction = failedVerifyManager.CheckOperatorResult(45, false);
            #endregion

            #region Assert
            lessThan30SecondAction.Should().BeFalse();
            greaterThan30SecondAction.Should().BeFalse();
            #endregion
        }

        [Test]
        public void CheckOperatorResult_WithTrueVerifyConfirmedAndLessThan30Second_ReturnTrue()
        {
            #region Arrange

            Mock<IAccessLogManager> accessLogManagerMoq = new Mock<IAccessLogManager>();
            Mock<IFailedVerifyMailSender> failedVerifyMailMoq = new Mock<IFailedVerifyMailSender>();
            FailedVerifyManager failedVerifyManager = new FailedVerifyManager(accessLogManagerMoq.Object, failedVerifyMailMoq.Object);
            #endregion

            #region Action
            bool checkAction = failedVerifyManager.CheckOperatorResult(29, true);
            #endregion

            #region Assert
            checkAction.Should().BeTrue();
            #endregion
        }
    }
}
