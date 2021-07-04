using System;
using Xunit;

namespace HeboTech.TimeService.Tests
{
    // Tests must be called in specific order in order to test the first uninitialized state (because it is a static service).
    [TestCaseOrderer("HeboTech.TimeService.Tests.AlphabeticalOrderer", "HeboTech.TimeService.Tests")]
    public class TimeServiceTests
    {
        [Fact]
        public void A_SystemTime_now_throws_exception_when_provider_is_not_set_test()
        {
            Assert.Throws<NullReferenceException>(() => TimeService.Now);
        }

        [Fact]
        public void B_SystemTime_setConstant_sets_the_provided_time_test()
        {
            DateTime time = new(2021, 1, 1);

            TimeService.SetConstant(time);

            Assert.Equal(time, TimeService.Now);
        }

        [Fact]
        public void C_SystemTime_set_throws_exception_when_argument_is_null_test()
        {
            Assert.Throws<ArgumentNullException>(() => TimeService.Set(null));
        }

        [Fact]
        public void D_SystemTime_set_sets_the_provided_time_function_test()
        {
            DateTime time = new(2021, 1, 1);

            TimeService.Set(() => time);

            Assert.Equal(time, TimeService.Now);
        }
    }
}
