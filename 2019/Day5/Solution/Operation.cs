using System;

namespace Day5
{
    public class Operation
    {
        public OpCode OpCode { get; }
        public Mode FirstParameterMode { get; }
        public Mode SecondParameterMode { get; }
        public Mode ThirdParameterMode { get; }

        public Operation(int operation)
        {
            var operationParts = operation.ToString().ToCharArray();
            var partE = operationParts.Length - 1 >= 0 ? operationParts[operationParts.Length - 1] : '0';
            var partD = operationParts.Length - 2 >= 0 ? operationParts[operationParts.Length - 2] : '0';
            var partC = operationParts.Length - 3 >= 0 ? operationParts[operationParts.Length - 3] : '0';
            var partB = operationParts.Length - 4 >= 0 ? operationParts[operationParts.Length - 4] : '0';
            var partA = operationParts.Length - 5 >= 0 ? operationParts[operationParts.Length - 5] : '0';

            OpCode = (OpCode)((Int32.Parse(partD.ToString()) * 10) + Int32.Parse(partE.ToString()));

            FirstParameterMode = Enum.Parse<Mode>(partC.ToString());
            SecondParameterMode = Enum.Parse<Mode>(partB.ToString());
            ThirdParameterMode = operationParts.Length >= 5 ? Enum.Parse<Mode>(partA.ToString()) : Mode.Position;
        }
    }

    public enum OpCode
    {
        Add = 1,
        Multiply = 2,
        Input = 3,
        Output = 4,
        Halt = 99
    }

    public enum Mode
    {
        Position = 0,
        Immediate = 1
    }
}