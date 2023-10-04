using Scheduling;

namespace Team4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PCB_InitializesWithProcessName()
        {
            //Arrange
            string processName = "WebView";
            //Act
            PCB pCB = new PCB { ProcessName = processName};
            //Assert
            Assert.AreEqual(processName, pCB.ProcessName);
        }

        [TestMethod]

        public void PCB_InitializesWithProcessPriority()
        {
            //Arrange
            int priority = 5;
            //Act
            PCB pcb = new PCB { ProcessPriority = priority};
            //Assert
            Assert.AreEqual(priority, pcb.ProcessPriority);
        }
        [TestMethod]
        public void PCB_InitializesWithProcessNameAndPriority()
        {
            // Arrange
            string processName = "Process A";
            int processPriority = 1;

            // Act
            var pcb = new PCB { ProcessName = processName, ProcessPriority = processPriority };

            // Assert
            Assert.AreEqual(pcb.ProcessName, processName);
            Assert.AreEqual(pcb.ProcessPriority, processPriority);
        }

        [TestMethod]

        public void PCB_ToString_ReturnsProcessNameAndPriority()
        {
            // Arrange
            string processName = "Process A";
            int processPriority = 1;
            var pcb = new PCB { ProcessName = processName, ProcessPriority = processPriority };

            // Act
            string result = pcb.ToString();

            // Assert
            Assert.AreEqual(result, $"{processName}({processPriority})");
        }
        [TestMethod]
        public void PCB_ProcessState_CanBeSetAndRetrieved()
        {
            // Arrange
            var pcb = new PCB();

            // Act
            pcb.ProcessState = PCB.ProcessStateType.Ready;
            var result = pcb.ProcessState;

            // Assert
            Assert.AreEqual(result, PCB.ProcessStateType.Ready);
        }
    }
}