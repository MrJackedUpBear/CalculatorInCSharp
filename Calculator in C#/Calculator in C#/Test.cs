using System.Runtime.InteropServices;
using static Program;

class Test{
    static void Main(String[] args){
        String input = "";
        String operatorsInUse = "";

        int numTests = 10;

        List<String> validOperators = ["-","+","*","/","(","!","^", "%"];
        List<String> validNum = ["0","1","2","3","4","5","6","7","8","9","-1","-2","-3","-4","-5","-6","-7","-8","-9"];

        Random random = new();

        for (int i = 0; i < numTests; i++){
            int numOperators = random.Next(5, 10);
            for (int j = 0; j < numOperators; j++){
                int op = random.Next(0, 8);
                operatorsInUse += validOperators[op];
            }
            Console.WriteLine(operatorsInUse);
            operatorsInUse = "";
        }
    }
}