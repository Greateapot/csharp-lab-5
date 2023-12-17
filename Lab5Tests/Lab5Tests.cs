namespace Lab5Tests
{
    public class Lab5Test
    {
        [Fact]
        public void Test()
        {
            var consoleIO = new TestableConsoleIO();

            //* main menu -> task1 menu
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input array
            consoleIO.PushLine("3", "3", "4", "2");
            //* task 1 option 1 test input
            consoleIO.PushTest(TestTask1Input);
            //* task 1 option 1 test output
            consoleIO.PushTest(TestTask1Output);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task1 menu -> option 2 select -> option 2 enter -> option 2 pause
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* task1 menu -> option 3 select (back) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* main menu -> option 2 select (task 2 menu) -> option 2 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* task 2 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 option 1 input table
            consoleIO.PushLine("2", "2", "3", "4", "1", "2");
            //* task 2 option 1 input k
            consoleIO.PushLine("3");
            //* task 2 option 1 test input
            consoleIO.PushTest(TestTask2Input);
            //* task 2 option 1 test output
            consoleIO.PushTest(TestTask2Output);
            //* task 2 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 menu -> option 2 select -> option 2 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* task 2 option 2 input k
            consoleIO.PushLine("3");
            //* task 2 option 2 pause
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 menu -> option 3 select (back) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* main menu -> option 3 select (task 3 menu) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* task 3 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 3 option 1 input jagArray
            consoleIO.PushLine("3", "3", "1", "3", "4", "2", "5", "6", "3", "2", "3", "5");
            //* task 3 option 1 test input
            consoleIO.PushTest(TestTask3Input);
            //* task 3 option 1 test output
            consoleIO.PushTest(TestTask3Output);
            //* task 3 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 3 menu -> option 2 select -> option 2 enter -> option 2 pause
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* task 3 menu -> option 3 select (back) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* main menu -> opt4 select (exit) -> opt4 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);

            Program.MainDialog();
        }

        private void TestTask1Input(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Int32[3] { 3, 4, 2 }\nОтфильтрованный";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        // @oleovic
        private void TestTask1Output(string? output)
        {
            // arrange
            var exceptedOutput = "Отфильтрованный одномерный массив: Int32[1] { 4 }\n\n";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }

        private void TestTask2Input(string? output)
        {
            // arrange
            var exceptedOutput = "Двумерный массив: Int32[2, 2] {\n\t{ 3, 4 },\n\t{ 1, 2 }\n}\nРасширенный";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }

        private void TestTask2Output(string? output)
        {
            // arrange
            var exceptedOutput = "Расширенный двумерный массив: Int32[2, 5] {\n\t{ 0, 0, 0, 3, 4 },\n\t{ 0, 0, 0, 1, 2 }\n}\n\n";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }

        private void TestTask3Input(string? output)
        {
            // arrange
            var exceptedOutput = "Рваный массив: Int32[3][] {\n\tInt32[3] { 1, 3, 4 },\n\tInt32[2] { 5, 6 },\n\tInt32[3] { 2, 3, 5 }\n}\nОтфильтрованный";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }

        private void TestTask3Output(string? output)
        {
            // arrange
            var exceptedOutput = "Отфильтрованный рваный массив: Int32[2][] {\n\tInt32[3] { 1, 3, 4 },\n\tInt32[3] { 2, 3, 5 }\n}\n\n";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
    }
}