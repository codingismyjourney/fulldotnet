using ConsoleApp.Basic;
using ConsoleApp.Basic2;
using ConsoleApp.Basic3;
using ConsoleApp.Exam;
/*

 .........................tenGenerics.......................
 //tenGenerics.oneFunction(10, 20);

 //tenGenerics.twoFunction<int>(4, 10);
 //tenGenerics.twoFunction<string>("India", "Bharat");

 //tenGenerics.twoFunction<int>(5, 5);
 //tenGenerics.twoFunction<string>("India", "India");


 .....................nineCollections........................
 nineCollections obj_nineCollections = new nineCollections();
 //obj_nineCollections.oneArrayList();
 //obj_nineCollections.twoHashTable();
 //obj_nineCollections.thirdSortedList();
 //obj_nineCollections.fourStack();
 //obj_nineCollections.fiveQueue();

 .........................eightDelegates............................
 Del_oneHello del_Test = new Del_oneHello(eightDelegates.oneHello);

 del_Test("I am here to learn a ASP.net");

 Del_twoHelloWorld del_Test2 = new Del_twoHelloWorld(eightDelegates.twoHelloWorld);

 del_Test2("Ajay Jethava", "Asp.net Core");

 Del_oneHello del_Test3 = new Del_oneHello(eightDelegates.thirdHello);

 del_Test3("TechnoNIC");


 ......................sevenIndexers....................
 sevenIndexers obj_sevenIndexers = new sevenIndexers();
 obj_sevenIndexers[0] = "Ajay";
 obj_sevenIndexers[1] = "Ajay1";
 obj_sevenIndexers[2] = "Ajay2";
 obj_sevenIndexers[3] = "Ajay3";
 obj_sevenIndexers[4] = "Ajay4";
 obj_sevenIndexers[5] = "Ajay5";
 obj_sevenIndexers[6] = "Ajay6";

 for (int i = 0; i < sevenIndexers.size; i++)
 {
     Console.WriteLine(obj_sevenIndexers[i]);
 }


 ......................sixFolderClass....................
 sixFolderClass obj_sixFolderClass = new sixFolderClass();
 obj_sixFolderClass.oneIOTest();

 ....................fiveReflection.......................
 fiveReflection obj_fiveReflection = new fiveReflection();
 obj_fiveReflection.oneReflectionTest();
 obj_fiveReflection.twoReflectionTest();


 .................fourProperties..........................
 fourProperties obj_fourProperties = new fourProperties();
 obj_fourProperties.ID = 101;
 obj_fourProperties.MobileNo = 9913578;
 obj_fourProperties.FirstName = "Ajay";
 obj_fourProperties.LastName = "Jethava";

 Console.WriteLine("Details is : {0} ", obj_fourProperties);


 ..........................threeAttributeClass..........................
 threeAttributeClass obj_threeAttributeClass = new threeAttributeClass();
 //int result = obj_threeAttributeClass.oneSum(10, 20);
 //int result1 = obj_threeAttributeClass.oneSum(10, 20, 30);
 //Console.WriteLine("Result is = {0}", result);

 int result = obj_threeAttributeClass.twoSum(10, 20);
 int result1 = obj_threeAttributeClass.twoSum(10, 20, 30);
 Console.WriteLine("Result is = {0}", result);


 ......................twoTextFileWork......................
 twoTextFileWork obj_twoTextFileWork = new twoTextFileWork();
 //obj_twoTextFileWork.oneTextFileCreate();
 //obj_twoTextFileWork.twoTextFileRead();

 Console.WriteLine("Hiiiii.....");

 .........................oneExceptionHandling..............................
 oneExceptionHandling obj_oneExceptionHandling = new oneExceptionHandling();
 obj_oneExceptionHandling.oneTryCatch();

 .........................oneStudent.............................
 oneStudent obj_oneStudent = new oneStudent(101,"Ajay","Jethava");
 obj_oneStudent.oneFullName();

  */

/*

        ..............nineOperatorOverloading.......................
        nineOperatorOverloading nOO1 = new nineOperatorOverloading();
        nineOperatorOverloading nOO2 = new nineOperatorOverloading();
        nineOperatorOverloading nOO3 = new nineOperatorOverloading();

        nOO1.oneNumber = 10;
        nOO1.twoNumber = 20;

        nOO2.oneNumber = 30;
        nOO2.twoNumber = 40;

        nOO3 = nOO1 + nOO2;

        nOO3.oneTotal();

.............................eightChildClassPolymorphism......................................
eightChildClassPolymorphism obj_eightChildClassPolymorphism = new eightChildClassPolymorphism();
obj_eightChildClassPolymorphism.oneSumFunction();
obj_eightChildClassPolymorphism.twoSumFunction();
obj_eightChildClassPolymorphism.verFunction();


........................eightFunctionOverloadingPolymorphism.................
eightFunctionOverloadingPolymorphism obj_eightFunctionOverloadingPolymorphism = new eightFunctionOverloadingPolymorphism();
obj_eightFunctionOverloadingPolymorphism.oneTestFunction();
obj_eightFunctionOverloadingPolymorphism.oneTestFunction(10);
obj_eightFunctionOverloadingPolymorphism.oneTestFunction(10, 5);
obj_eightFunctionOverloadingPolymorphism.oneTestFunction("Ajay");

.......................sevenMultipleInheritanceClassChild....................
sevenMultipleInheritanceClassChild obj_sevenMultipleInheritanceClassChild = new sevenMultipleInheritanceClassChild();
obj_sevenMultipleInheritanceClassChild.oneTest();
obj_sevenMultipleInheritanceClassChild.twoTest();
obj_sevenMultipleInheritanceClassChild.threeTest();

........................sixInterfaceClass....................................
sixInterfaceClass obj_sixInterfaceClass = new sixInterfaceClass();
int no1 = 10, no2 = 20;
int result = obj_sixInterfaceClass.oneTotal(no1 , no2);
Console.WriteLine("Total is = {0}",result);


...........................fiveInheritanceClass...............................
fiveInheritanceClass obj_fiveInheritanceClass = new fiveInheritanceClass();
obj_fiveInheritanceClass.width = 10;
obj_fiveInheritanceClass.height = 5;
int result = obj_fiveInheritanceClass.getArea();
Console.WriteLine("Result is = {0}",result);

...................fourStaticClass.............................................
fourStaticClass.fullName();
fourStaticClass.fName = "New Ajay";
fourStaticClass.lName = "New Jethava";
fourStaticClass.fullName();


................................threeEncapsulationClass2...............................
threeEncapsulationClass2 obj_threeEncapsulationClass2 = new threeEncapsulationClass2();
int result = obj_threeEncapsulationClass2.oneResult();
Console.WriteLine("Result is = {0}",result);

..............................threeEncapsulationClass..............................
threeEncapsulationClass obj_threeEncapsulationClass = new threeEncapsulationClass();
obj_threeEncapsulationClass.id = 101;
obj_threeEncapsulationClass.fName = "Ajay";
obj_threeEncapsulationClass.lName = "Jethava";
obj_threeEncapsulationClass.printDetail();

........................twoDefaultClass...........................................
twoDefaultClass obj_twoDefaultClass = new twoDefaultClass();
obj_twoDefaultClass.oneFunctionTest();
obj_twoDefaultClass.twoFunctionTest();

........................oneDefaultClass............................................
oneDefaultClass obj_oneDefaultClass = new oneDefaultClass();
//obj_oneDefaultClass.oneFunctionTest();
//obj_oneDefaultClass.twoFunctionTest();

*/

/*

.........................fourteenEnums Class....................................
fourteenEnums obj_fourteenEnums = new fourteenEnums();
//obj_fourteenEnums.oneEnumTest();
//obj_fourteenEnums.twoEnumTest();

..........................thirteenStructure Class................................
thirteenStructure obj_thirteenStructure = new thirteenStructure();
obj_thirteenStructure.oneStructData();

.........................twelveStructure Class....................................
twelveStructure obj_twelveStructure = new twelveStructure();
//obj_twelveStructure.oneTestStructure();

..........................elevenStructures Class...................................
elevenStructures obj_elevenStructures = new elevenStructures();
//obj_elevenStructures.oneStruc();


................tenSumMix class................
tenSumMix obj_tenSumMix = new tenSumMix();
//obj_tenSumMix.oneDataType();
//obj_tenSumMix.twoBool();
//obj_tenSumMix.threeByte();
//obj_tenSumMix.fourChar();
//obj_tenSumMix.fiveDecimal();
//obj_tenSumMix.sixFloat();
//obj_tenSumMix.sevenLong();
//obj_tenSumMix.eightSbyte();
//obj_tenSumMix.nineShort();
//obj_tenSumMix.tenConst();


........................nineString Class..................
nineString obj_nineString = new nineString();
//obj_nineString.oneString();
//obj_nineString.twoCharToString();
//obj_nineString.threeJoinArray();
//obj_nineString.fourCompareString();
//obj_nineString.fiveSearchString();
//obj_nineString.sixSearchString();
/*

............................eightArrayNumbers class...............

eightArrayNumbers obj_eightArrayNumbers = new eightArrayNumbers();
//obj_eightArrayNumbers.oneCheckJArray();

//int[] myNumbers = new int[] { 10, 20, 30, 566 };

//double mySum = obj_eightArrayNumbers.twoPassArrays(myNumbers);
//Console.WriteLine("Total is: {0}", mySum);

//int mySum = obj_eightArrayNumbers.threeParamArray(10, 248, 365);
//Console.WriteLine("As per params My Array is: {0}", mySum);

//obj_eightArrayNumbers.fourArrayClass();

......................sevenArrayNumbers class......................

//sevenArrayNumbers obj_sevenArrayNumbers = new sevenArrayNumbers();
//obj_sevenArrayNumbers.oneTwoArray();
//obj_sevenArrayNumbers.twoReadandWriteDArray();

...................sixTypeFunctions.............................

sixTypeFunctions obj_sixTypeFunctions = new sixTypeFunctions();
//obj_sixTypeFunctions.oneFunction();
//int returntwovalue = obj_sixTypeFunctions.twoFunction();
//Console.WriteLine("Return value is {0}",returntwovalue);

//int maxNumberIs = obj_sixTypeFunctions.threeFindMax(5,3);
//Console.WriteLine("Max is : {0}", maxNumberIs);

//Console.WriteLine("Enter Number to find Factorial: ");
//int paraFactorialNo = Convert.ToInt32(Console.ReadLine());

//int returnFactorial = obj_sixTypeFunctions.fourFactorial(paraFactorialNo);
//Console.WriteLine("Factorial is: {0}",returnFactorial);

//int myNumber1 = 45;
//int myNumber2 = 79;

//Console.WriteLine("Before Swapping First Number is: {0}",myNumber1);
//Console.WriteLine("Before Swapping Second number is: {0}",myNumber2);

//obj_sixTypeFunctions.fiveSwap(ref myNumber1 , ref myNumber2);

//Console.WriteLine("After Swap Number one is: {0}",myNumber1);
//Console.WriteLine("After Swap Number Two is: {0}",myNumber2); 

//obj_sixTypeFunctions.sixNullTest();
//obj_sixTypeFunctions.sevenNullTest();

.....................fiveArrayNumbers Class..................

fiveArrayNumbers obj_fiveArrayNumbers = new fiveArrayNumbers();
//obj_fiveArrayNumbers.singleArrayTest();
//obj_fiveArrayNumbers.singleArrayTestReadWrite();
//obj_fiveArrayNumbers.doubleArrayTestReadWrite();

....................fourNumbers............................

fourNumbers obj_fourNumbers = new fourNumbers();
//obj_fourNumbers.whileLoopTest();
//obj_fourNumbers.whileLoopTestNew();
//obj_fourNumbers.forLoopTest();
obj_fourNumbers.doWhileLoopTest();

.......................threeNumbers class..................

threeNumbers obj_threeNumbers = new threeNumbers();
// obj_threeNumbers.switchTestOne();
obj_threeNumbers.switchTestNested();


.......................twoNumbers Class......................

twoNumbers obj_twoNumbers = new twoNumbers();   
//obj_twoNumbers.ifCheckPrint();
//obj_twoNumbers.ifElseCheckPrint();
//obj_twoNumbers.ifElseCheckPrintWithEq();
obj_twoNumbers.ifElseElsePrint();


...............oneHelloWorld class.................
*/


oneHelloWorld obj_oneHelloWorld = new oneHelloWorld();
obj_oneHelloWorld.printMyMessage();
obj_oneHelloWorld.printMyVar();
obj_oneHelloWorld.printSum();
obj_oneHelloWorld.printFloatNumbers();
obj_oneHelloWorld.printDecimalNumbers();
obj_oneHelloWorld.getNumbersfromUsers();
obj_oneHelloWorld.getNumbersfromUsersDec();



/*

functionOverloading obj_functionOverloading = new functionOverloading();
obj_functionOverloading.oneFunction(5,3);
obj_functionOverloading.oneFunction(5, 3, 2);

test5 obj_test5 = new test5();
obj_test5.getNumberfromUser();
obj_test5.addNumbers();

test6 obj_test6 = new test6();
obj_test6.getNumberfromUser();
obj_test6.subNumbers();
test2 obj_test2 = new test2();
obj_test2.
obj_test2.twoTest();


test3 obj_test3 = new test3();
obj_test3.
obj_test3.twoTest();

 */