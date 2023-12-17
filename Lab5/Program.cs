using ArrayUtilsLib;
using ConsoleDialogLib;
using ConsoleIOLib;

namespace Lab5
{
    public class Program
    {
        public static void Main() => ConsoleDialog.ShowDialog(MainDialog());

        public static ConsoleDialog MainDialog() =>
            new(
                Messages.MainMenuWelcome,
                options: new(){
                    new(
                        Messages.MainMenuOptionTask1,
                        (dialog) => ConsoleDialog.ShowDialog(Task1Dialog())
                    ),
                    new(
                        Messages.MainMenuOptionTask2,
                        (dialog) => ConsoleDialog.ShowDialog(Task2Dialog())
                    ),
                    new(
                        Messages.MainMenuOptionTask3,
                        (dialog) => ConsoleDialog.ShowDialog(Task3Dialog())
                    )
                }
            );

        private static ConsoleDialog Task1Dialog() =>
            new(
                Messages.Task1MenuWelcome,
                options: new(){
                    new(
                        Messages.TasksMenuOptionInput,
                        (dialog) => Task1Process(),
                        pauseAfterExecuted: true
                    ),
                    new(
                        Messages.TasksMenuOptionRandom,
                        (dialog) => Task1Process(true),
                        pauseAfterExecuted: true
                    )
                }
            );

        private static ConsoleDialog Task2Dialog() =>
            new(
                Messages.Task2MenuWelcome,
                options: new(){
                    new(
                        Messages.TasksMenuOptionInput,
                        (dialog) => Task2Process(),
                        pauseAfterExecuted: true
                    ),
                    new(
                        Messages.TasksMenuOptionRandom,
                        (dialog) => Task2Process(true),
                        pauseAfterExecuted: true
                    )
                }
            );

        private static ConsoleDialog Task3Dialog() =>
            new(
                Messages.Task3MenuWelcome,
                options: new(){
                    new(
                        Messages.TasksMenuOptionInput,
                        (dialog) => Task3Process(),
                        pauseAfterExecuted: true
                    ),
                    new(
                        Messages.TasksMenuOptionRandom,
                        (dialog) => Task3Process(true),
                        pauseAfterExecuted: true
                    )
                }
            );

        private static void Task1Process(bool random = false)
        {
            var array = random ? ArrayUtils.CreateRandomArray() : ArrayUtils.CreateArray<int>();
            ArrayUtils.PrettyPrintArray(array, Messages.Task1ProcessOutput);
            ArrayUtils.PrettyPrintArray(Tasks.FilterArray(array), Messages.Task1ProcessOutputFiltered);
        }

        private static void Task2Process(bool random = false)
        {
            var table = random ? ArrayUtils.CreateRandomTable() : ArrayUtils.CreateTable<int>();
            var k = ConsoleIO.Input<uint>(Messages.Task2ProcessInput);
            ArrayUtils.PrettyPrintArray(table, Messages.Task2ProcessOutput);
            ArrayUtils.PrettyPrintArray(Tasks.ExtendTable(table, k), Messages.Task2ProcessOutputExtended);
        }

        private static void Task3Process(bool random = false)
        {
            var jagArray = random ? ArrayUtils.CreateRandomJagArray() : ArrayUtils.CreateJagArray<int>();
            ArrayUtils.PrettyPrintArray(jagArray, Messages.Task3ProcessOutput);
            ArrayUtils.PrettyPrintArray(Tasks.FilterJagArray(jagArray), Messages.Task3ProcessOutputFiltered);
        }
    }
}