namespace Executor.IO.Commands
{
    using Executor.Attributes;
    using Executor.Exceptions;

    [Alias("cdabs")]
    internal class ChangeAbsolutePathCommand : Command
    {
        [Inject]
        private IOManager inputOutputManager;

        public ChangeAbsolutePathCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string absolutePath = this.Data[1];
            this.inputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
        }
    }
}