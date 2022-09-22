using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLabLibrary.Test
{
    public class ZooAppTest
    {
        [Fact]
        public void ShouldBeAbleToCreateZooApp()
        {
            ZooApp zooApp = new ZooApp();
            Assert.NotNull(zooApp);
        }

        [Fact]
        public void ShouldBeAbleToAddZooToZooAppAndGetZoos()
        {
            ZooApp zooApp = new ZooApp();
            zooApp.AddZoo(new Zoo(location: "New York"));
            Assert.NotEmpty(zooApp.GetZoos());
        }
    }
}
