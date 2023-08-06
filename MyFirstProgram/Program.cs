using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // In ra hello nhưng viết trên 1 hàng
            //Console.Write("Hello");
            // cú pháp in ra Console.WriteLine("Hello world");
            // hết 1 cú pháp phải có dấu ;
            //writeLine bắt đầu viết trên 1 dòng mới
            //Console.WriteLine("Hello world");
            //Console.WriteLine("I like pizza");
            //phát ra tiếng kêu beep
            //Console.Beep();

            // tab với \t
            //Console.WriteLine("\tBrocode");
            //cắt bỏ chữ o với \b
            //Console.WriteLine("Bro\bCode");
            //newline
            //Console.WriteLine("Bro\nCode");



            // Khai báo biến
            /**
             Bước 1: Định nghĩa, khai báo
             Bước 2: khởi tạo
             */
            // kiểu dữ liệu - tên biến
            int x; // declaration định nghĩa
            x = 123; // initialization khởi tạo

            // Gộp 2 bước thành 1
            int y = 321;

            Console.WriteLine(x);
            Console.WriteLine(y);

            int z = y + x;
            Console.WriteLine(z);

            int age = 21; //whole integer

            //int kiểu số nguyên
            //double kiểu số thực
            double height = 1.75; // decimal number

            bool alive = true; // boolean

            char symbol = '@';
            //char là một kiểu dữ liệu nguyên thủy trong C# đại diện cho một ký tự.
            //Một ký tự có thể là một chữ cái, một số, một ký hiệu hoặc một khoảng trắng

            //String chuỗi
            String name = "tuan";

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "m");

            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            Console.WriteLine("Your symbol is: " + name);

            //Thực hiện nối chuỗi
            String userName = symbol + name;
            Console.WriteLine("Your username is: " + userName);


            double pi = 3.14159;

            pi = 420;

            Console.WriteLine(pi);

            // constats = immutable values which are known at complie time
            //             and do not change for the life of the program.

            //các giá trị bất biến được biết tại thời điểm tuân thủ và không thay đổi trong suốt vòng đời của chương trình.

            const double numberPi = 3.14159;

            Console.WriteLine("Đây là số Number Pi" + numberPi);




            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            // type casting =  Chuyển đổi một giá trị thành một loại dữ liệu khác.
            //                 Hữu ích khi chúng tôi chấp nhận đầu vào của người dùng (chuỗi).
            //                 Các loại dữ liệu khác nhau có thể làm những việc khác nhau

            // chuyển đổi số thực thành số nguyên
            //Phép Convert.ToInt32(a) trong C# được sử dụng để chuyển đổi một giá trị bất kỳ thành một số nguyên. 
            double a = 3.14;
            int b = Convert.ToInt32(a);

            //kiểm tra kiểu dữ liệu của a 
            Console.WriteLine(a.GetType());
            //Kiểm tra kiểu dữ liệu của b, sau khi chuyển đổi a nạp vào b
            Console.WriteLine(b.GetType());

            Console.WriteLine(b);


            //Chuyển đổi kiểu số nguyên thành số thực
            int c = 123;
            double d = Convert.ToDouble(c);
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());

            Console.WriteLine(d);

            //Chuyển đổi số thành chuỗi
            int e = 321;
            String f = Convert.ToString(e);


            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());

            Console.WriteLine(f);

            //Chuyển đổi chuỗi thành char

            String g = "$";
            char h = Convert.ToChar(g);

            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);


            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());
            Console.WriteLine(i);


            // user inut
            // gán giá trị nhập vào biến name2
            Console.WriteLine("What is your name ?");
            String name2 = Console.ReadLine();

            // giá trị in ra nếu là kiểu số thì nên chuyển đổi nó thành số trước khi in ra tại vì WriteLine luôn nhận là chuỗi
            Console.WriteLine("How old are you ?");
            //chuyển đôi sang số sau đó bỏ dòng in kết quả ra vào trong nơi thực thi
            // nếu cố tình nhập kết quả chuỗi thì sẽ tạo ra 1 exception, lỗi
            // chuỗi "fish" và chuyển đổi sang số thì sẽ vi phạm ngoại lệ.
            // Các chương kế sẽ học xử lý in ra lỗi của exception
            int age2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Hello " + name2);
            Console.WriteLine("You are  " + age2 + " years old");



            //arithmetic operators Toán tử số học


            int friends = 5;
            //toán tử cộng
            //friends = friends + 1;

            //shortcuts
            //friends += 2;

            //friends++;

            //toán tử trừ
            //friends = friends - 1;

            //shortcuts
            //friends -= 2;

            //friends--;


            // Toán tử nhân
            //friends = friends * 1;

            //shortcuts
            //friends *= 2;

            // Toán tử chia
            //friends = friends / 2;

            //shortcuts
            friends /= 2;

            // Chia lấy dư
            int remainder = friends % 3;

            Console.WriteLine(friends);
            Console.WriteLine(remainder);



            //Math class
            double xx = 3.99;
            double zz = 5;
            //Math.Pow() nhận hai đối số: đối số đầu tiên là số cần bình phương, và đối số thứ hai là số mũ.
            //Pow này đã được c# định nghĩa sẵn chỉ cần lấy ra và dùng.
            double aa = Math.Pow(xx, 2);
            //Sqrt: căn bậc 2
            double bb = Math.Sqrt(xx);

            //Abs: trị tuyệt đối
            double cc = Math.Abs(xx);
            //Round làm tròn số lên nếu số thập phân lớn hơn hoặc bằng 0.5, và sẽ làm tròn số xuống nếu số thập phân nhỏ hơn 0.5
            //tham số thứ 2 là 1 optional, nếu có thì sẽ làm tròn đến chữ số thập phân được đặt theo yêu cầu
            double dd = Math.Round(xx);
            //Celling làm tròn lên
            double ee = Math.Ceiling(xx);
            //Floor /Round làm tròn xuống
            double ff = Math.Floor(xx);
            //Max tìm ra số lớn nhất
            double gg = Math.Max(xx, zz);
            //Min tìm ra số nhỏ nhất
            double hh = Math.Min(xx, zz);


            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);
            Console.WriteLine(dd);
            Console.WriteLine(ee);
            Console.WriteLine(ff);
            Console.WriteLine(gg);
            Console.WriteLine(hh);






            //Random Number
            //random này sẽ chạy từ 1 đến 2 tỷ 
            // nếu muốn giới hạn truyền tham số bắt đầu và kết thúc
            Random random = new Random();
            random.Next();

            //bài toán thẩy xí ngầu, xí ngầu 6 mặt 1 đến 6
            //Hàm Random.Next() trả về một số ngẫu nhiên trong khoảng từ min đến max.
            // tại sao 0 phải 6 mà là 7 vì số max này phải là điểm hạn cuối cùng vì vậy kết quả trả về phải luôn nhỏ hơn
            int num = random.Next(1, 7);

            Console.WriteLine(num);

            double nums = random.NextDouble();

            Console.WriteLine(nums);

            // này sẽ từ 0 -> 0.9999 số thập phân


            //hypotenuse calculator program: Viết chương trình tính cạnh huyền của tam giác
            // công thức = căn bậc 2 của a bình + b bình

            Console.WriteLine("Nhập cạnh a");
            double aaa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập cạnh b");
            double bbb  = Convert.ToDouble(Console.ReadLine());

            double ccc = Math.Sqrt((aaa * aaa) + (bbb * bbb));

            Console.WriteLine("Cạnh huyền là, The hypotenuse is: " + ccc);


            //string methods các phương thức chuỗi

            /**
             IndexOf(): Tìm kiếm một ký tự trong một chuỗi và trả về vị trí của ký tự.
             Replace(): Thay thế tất cả các lần xuất hiện của một ký tự trong một chuỗi bằng một ký tự khác.
             CompareTo(): So sánh hai chuỗi và trả về một giá trị cho biết chuỗi nào lớn hơn, nhỏ hơn hoặc bằng.
             ToUpper(): Chuyển đổi tất cả các ký tự trong một chuỗi thành chữ hoa.
             ToLower(): Chuyển đổi tất cả các ký tự trong một chuỗi thành chữ thường.
             Insert(): thêm một ký tự mới hoặc nội dung mới,... vào vị trí chỉ định
             */

            //khai báo kiểu dữ liệu + tên biến, gán dữ liệu
            String myFullName = "Tuan Nguyen Thai";
            // lấy tên biến gán lại một giá trị mới 
            myFullName = myFullName.ToUpper();
            //in ra
            Console.WriteLine(myFullName);

            myFullName = myFullName.ToLower();
            Console.WriteLine(myFullName);

            String phoneNumber = "123-456-7890";
            //sử dụng replace thay thế 1 hay nhiều ký trong chuỗi mà bạn muốn thay thế
            phoneNumber = phoneNumber.Replace("-", " ");
            Console.WriteLine(phoneNumber);

            // tham số thứ 1 vị trí, tham số thứ 2 là nội dung được thêm vào
            myFullName = myFullName.Insert(0, "@");
            Console.WriteLine(myFullName);

            myFullName = myFullName.Insert(0, "Mr/Mrs. ");
            Console.WriteLine(myFullName);

            //Đếm số lượng chữ 
            Console.WriteLine(myFullName.Length);

            //Lấy ra ký tự mong muốn
            // tham số thứ 1 vị trí bắt đầu, tham số thứ 2 độ dài muốn lấy (legnth)
            //phân biệt index bắt đầu từ 0
            //length bắt đầu từ 1,
            // 0  ở đầy là vị trí bắt đầu của index đó
            //4 ở đây có nghĩa là độ dài là 4
            string myFirstName = myFullName.Substring(0, 4);
            //index vị trí 5 và độ dài cần lấy là 6
            string myLastName = myFullName.Substring(5, 6);
            //full họ
            string myLastName2 = myFullName.Substring(5, 11);
            Console.WriteLine(myFirstName);
            Console.WriteLine(myLastName);
            Console.WriteLine(myLastName2);

            // If else statement a basic form of decision making (một hình thức cơ bản của việc ra quyết định)

            Console.WriteLine("Please enter your age: ");
            int myAge = Convert.ToInt32(Console.ReadLine());

            if (myAge >= 18)
            {
                Console.WriteLine("You are now signed up: ");

            }
            else if (age > 100)
            {
                Console.WriteLine("You are old to sign up! ");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet! ");
            }
            else
            {
                Console.WriteLine("You must be 18+ sign up! ");

            }


            Console.WriteLine("Please enter name your mom: ");
            string nameMyMom = Console.ReadLine();

            if(nameMyMom == "")
            {
                Console.WriteLine("You didn't enter your name");
            }
            else
            {
                Console.WriteLine("Hello" + nameMyMom);
            }

            // Viết cách 2

            if (nameMyMom != "")
            {
                Console.WriteLine("Hello" + nameMyMom);
            }
            else
            {
                Console.WriteLine("You didn't enter your name");
            }



            // switch case = an effcient alternative to many else if statements

            Console.WriteLine("What is day today? ");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not day");
                    break;
            }



            // Logical operator 
            /**
                && (And)
                || (Or)
             */

            Console.WriteLine('What is the temperature outside: (C)');
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm out side");
            }
            else if(temp >= -50 || temp <= 50)
            {
                Console.WriteLine("Do not go to out side");
            }
            else
            {
                Console.WriteLine("I don't know");
            }



            //while loops = repeats some code while some condition remains true

            Console.WriteLine("Enter your name: ");
            String nameYourDad = Console.ReadLine();

            // vòng lặp while điều kiện tên phải bỏ trống, ||
            // Nếu mà điều kiện thỏa thì chứng tỏ người dùng chưa nhập,
            // nếu không thỏa điều kiện người dùng đã nhập 1 cái gì đó.
            // Mà đã nhập rồi thì sẽ khồn chạy qua while
            while(nameYourDad == "")
            {
                //nó lặp đi lặp lại vô hạn nếu mà điều kiện vẫn đúng
                Console.WriteLine("Enter your name: ");
                nameYourDad = Console.ReadLine();
            }
            Console.WriteLine("Hello" + nameYourDad);

            // vòng lặp vô hạn cần tránh while(1 == 1)

            // For loops = repeats some code a FINITE amount of times
            //               lặp lại một đoạn mã một số lần CÓ HẠN.

            //for loop bị giới hạn
            //bắt đầu từ 0 và tằng lên 1 và có thể đạt cực đại là 10
            for (int i = 0; i <= 10; i++ )
            {
                Console.WriteLine(i);
            }
            // bắt đầu từ 0 và 1 lần tăng lên 2
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // count down
            // cách này không tối ưu
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                if (i == 0)
                {
                    Console.WriteLine("Happy New Year !!!");
                }
            }

            // cách tối ưu hơn
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);  
            }
            Console.WriteLine("Happy New Year !!!");

            


            //nested loops vòng lặp lồng nhau
            //Bước 1 cho nhập
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            //Bước 2 truyền số nhập vào vòng lặp
            for (int i = 0; i < rows; i++)
            {
                for (int z = 0; z < cols; z++)
                {
                    //Bước 3 vẽ
                    Console.Write("@");
                }
                Console.WriteLine();
            }

            // cách 2: dùng while kết hợp for
            Console.Write("How many rowspans? ");
            int rowspans = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many colspans? ");
            int colspans = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the symbol? ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rowspans; i++)
            {
                for (int j = 0; j < colspans; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }



            //number guessing game: Trò chơi đoán số
            
            Random random1 = new Random();
            //trong C# tạo ra một thể hiện mới của lớp Random.
            //Lớp Random được sử dụng để tạo ra các số ngẫu nhiên giả.
            //Hàm tạo new Random() sử dụng thời gian hệ thống hiện tại làm giá trị hạt cho trình tạo số ngẫu nhiên.
            //Điều này có nghĩa là mỗi khi đoạn mã được chạy, đối tượng Random sẽ tạo ra một dãy số ngẫu nhiên khác nhau.

            // định nghĩa 1 số giá biến
            bool playAgain = true; // phải bằng true mới chạy vào được while, lý do có truyền vào playAgian = true (viết gọn playAgian )
            int min = 1;
            int max = 100;
            // một số định nghĩa chưa được đặt giá trị
            int guess;
            int number;
            int guesses;
            String response; // kết quả trả về

            while (playAgain)
            {
                // gán các giá trị ban đầu trước khi bắt đầu
                guess = 0;
                guesses = 0;
                response = "";
                //Điều kiện tạo số min max
                /**
                   Tham số đầu tiên là giá trị thấp nhất của khoảng.
                   Tham số thứ hai là giá trị cao nhất của khoảng, không bao gồm giá trị này.
                 */
                //max + 1 lý do là 101 và số này Next sẽ đảm bảo là không bao gồm giá trị này đó là 101, max sẽ không chạy đến giá trị này.
                //phương thức Next() sẽ tạo ra một số ngẫu nhiên trong khoảng từ 1 đến 100, bao gồm cả 1 và không bao gồm 100.
                number = random1.Next(min, max + 1);
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between" + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if(guess > number)
                    {
                        Console.WriteLine(guess+ " is to high!");
                    }else if (guess < number) 
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Gusses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! ... I guess");


            // Bài tập: Giới hạn số lần đoán nếu quá số lần sẽ bị thua

            Random random2 = new Random();

            bool playAgain2 = true; // phải bằng true mới chạy vào được while, lý do có truyền vào playAgian = true (viết gọn playAgian )
            int min2 = 1;
            int max2 = 100;

            int guess2;
            int number2;
            int guesses2;
            String response2; // kết quả trả về

            while (playAgain2)
            {
                guess2 = 0;
                guesses2 = 0;
                response2 = "";
                number2 = random2.Next(min2, max2 + 1);
                while (guess2 != number2 && guesses2 < 10) // Thêm điều kiện guesses < 10
                {
                    Console.WriteLine("Guess a number between" + min2 + " - " + max2 + " : ");
                    guess2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess2);

                    if (guess2 > number2)
                    {
                        Console.WriteLine(guess2 + " is to high!");
                    }
                    else if (guess2 < number2)
                    {
                        Console.WriteLine(guess2 + " is to low!");
                    }
                    guesses2++;
                }
                if (guess2 == number2)
                {
                    Console.WriteLine("Number: " + number2);
                    Console.WriteLine("You win!");
                    Console.WriteLine("Guesses: " + guesses2);
                }
                else
                {
                    Console.WriteLine("You lose! The number was: " + number2);
                }


                Console.WriteLine("Would you like to play again (Y/N or type any if you want exits): ");
                response2 = Console.ReadLine();
                response2 = response2.ToUpper();

                if (response2 != "Y")
                {
                    playAgain2 = false;
                }

                Console.WriteLine();
            }
            Console.WriteLine("Thanks for playing! ... ");



            // Game kéo búa bao

            /*
             //Đây là 1 hàm C# giúp tạo ra số bất kỳ khi được gọi
             Random random = new Random();
            // này là gán playAgain = true để lần chạy đầu tiên có thể bắt đầu chương trình
            bool playAgain = true;

            // khai báo 3 biến player, computer, anser
            String player;
            String computer;
            String answer;

            // dùng vòng lặp để chẹc xem là người dùng có đang muốn chơi game không, nếu mà ko vào vòng lặp thì in ra 1 cái gì đó
            while (playAgain)
            {
                // gán cho các giá trị biến chuỗi rỗng
                player = "";
                computer = "";
                answer = "";

                // dùng vòng lặp kiểm tra người dùng điền vào là gì, nếu khác 3 giá trị  ROCK PAPER SCISSORS thì sẽ bị rơi vào vòng lặp
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                // nếu không bị dính vào vòng lặp trên thì sẽ chạy tiếp dưới này
                // tiếp tục check điều kiện 
                // điều kiện: là gọi hàm random xong đưa vào khoảng 1 -> 4
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                
                // in ra kết quả player và computer đã chọn
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // check 2 kết quả của player và computer
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                // Câu này sẽ tự động đưa ra hỏi có muốn chơi tiếp không
                Console.Write("Would you like to play again (Y/N): ");

                // nhập vào câu trả lời
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                // check điều kiện answer
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                
            }

            // nếu thoát được vòng lặp, và in ra câu chào
            Console.WriteLine("Thanks for playing!");
             */


            //ẩn các thông tin không cần thiết, chỉ hiện code chạy, lưu ý luôn đặt cuối cùng, tránh ngăn chặn code chạy




            // calculator program: làm máy tính

            /*
             
             
             do
                {
                    double num1 = 0;
                    double num2 = 0;
                    double result = 0;

                    Console.WriteLine("------------------");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("------------------");

                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    Console.Write("Enter an option: ");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("That was not a valid option");
                            break;
                    }
                    
                    Console.Write("Would you like to continue? (Y = yes, N = No): ");
                } while (Console.ReadLine().ToUpper() == "Y"); 
                // vòng lặp do while nếu thỏa điều kiện thì sẽ tiếp tục lặp, không thì chạy tiếp

                Console.WriteLine("Bye!");
             
             
             */

            // Lý thuyết về vòng lặp do while
            /*
             Vòng lặp do-while sẽ chạy chắc chắn lần đầu, sau đó nó sẽ kiểm tra điều kiện vòng lặp. 
             Nếu điều kiện là đúng, vòng lặp sẽ chạy lại từ đầu. Quá trình này tiếp tục cho đến khi điều kiện là sai.
             */




            // Array = a variable that can store multiple values. fixed size
            // Mảng = một biến có thể lưu trữ nhiều giá trị. Kích thước cố định.
            // Hiểu nôn na là mảng => [], trong mảng có thể chứa các số, chuỗi các ký tự, true/false, đối tượng...

            // này chuỗi
            String car = "BMW";
            // muốn chuỗi thành mãng
            String[] cars = {"BMW"," Ford", "Lexus", "Mercedes"};

            Console.WriteLine(cars);// chỉ hiện ra type
            Console.WriteLine(cars[0]); // hiện ra được phần tử đứng vị trí đó
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            // gán lại giá trị trong mảng
            cars[0] = "Tesla";
            Console.WriteLine(cars[0]);

            // Trong này là code đồng bộ từ trên xuống dưới.


            // Bạn thấy việt Console.writeLine nhiều thấy cực không?
            // Hãy liên tưởng lại vòng lặp for

            // ngắn gọn như này thui. xong!!! 
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // mảng theo cách khác  || String[5] "độ dài" (length) của mảng là 5
            String[] fruits = new String[5];

            fruits[0] = "Banana ";
            fruits[1] = "Apple ";
            fruits[2] = "Orange ";
            fruits[3] = "Strawberry ";
            fruits[4] = "Coconut ";

            for(int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }


            // foreach loop = a simpler way to iterate over an array, but it's less flexible
            // vòng lặp for each = "Một cách đơn giản hơn để lặp qua một mảng, nhưng nó ít linh hoạt hơn."

            foreach (String fruit in fruits)
            {
                Console.WriteLine(fruit);
            }



            // method = performs a section of code, whenever it's called "invoked"
            //          benefit = Let's us reuse code w/o writing it multiple times.            

            /*
                Phương thức = thực hiện một phần mã, bất cứ khi nào nó được gọi "invoked: triệu hồi"
                        Lợi ích = Cho phép chúng ta tái sử dụng mã không cần viết lại nhiều lần
             */

            //bad: tệ code lặp khá nhiều lần
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday Happy birthday!!!");
            Console.WriteLine("Happy birthday to you!!!");

            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday Happy birthday!!!");
            Console.WriteLine("Happy birthday to you!!!");

            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday Happy birthday!!!");
            Console.WriteLine("Happy birthday to you!!!");

            //Good: nên dùng cách này, tối ưu code hơn

            // Bước 1: viết 1 phương thức singHappyBirthday() ở bên ngoài

            // Bước 2: thực hiện gọi phương thức đó vào trong đây
            singHappyBirthday(); // gọi phương thức || giống callbacks trong js nhỉ?
            singHappyBirthday();
            singHappyBirthday();

            /*
             Tóm tắt:

            Hàm Main() gọi hàm singHappyBirthday() ba lần. 
            Điều này có nghĩa là lời bài hát Chúc mừng sinh nhật sẽ được in ra ba lần. 
            Hàm singHappyBirthday() in ra lời bài hát Chúc mừng sinh nhật bằng cách gọi phương thức Console.WriteLine() ba lần. 
            Phương thức Console.WriteLine() in ra một chuỗi lên bảng điều khiển.


             */


            /*Hàm và có truyền đối số*/
            String myNameis = "Tuan"; // khai báo biến myNameis và gán giá trị dữ liệu
            int myAgeis = 23;
            // gọi hàm và truyền đối số
            sayHello(myNameis);

            //Truyền với 2 đối số
            howOldAreYou(myNameis, myAgeis);




            //Bài mới học về return

            // return = returns data back to the place where a method is invoked

            double xxxx;
            double yyyy;
            double oooo;

            double result;

            Console.WriteLine("Enter in number 1: ");
            xxxx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            yyyy = Convert.ToDouble(Console.ReadLine());

            result = Multiply(xxxx, yyyy); // gọi hàm Multiply sẽ trả về kết quả của zzzz và gán cho result

            Console.WriteLine("Mutiple: " + result);

            Console.WriteLine("Enter in number 3: ");
            oooo = Convert.ToDouble(Console.ReadLine());

            result = Multiply(xxxx, yyyy, oooo);
            Console.WriteLine("Mutiple: " + result);

            //method overloading 🤯

            //method overloading = methods share same name, but different parametters
            //                     name + parametters = signature
            //                     methods must have a unique signature

            // dịch:
            /*                      các phương thức có cùng tên nhưng khác tham số
                                    Tên + tham số = chữ ký (signature)
                                    các phương thức phải có một chữ ký duy nhất
             */





            // params keyword: a method parameter that takes a variable number of arguments
            //                The parameter type must be a single - dimensional array.

            /*
                "params keyword: một tham số của phương thức chấp nhận một số lượng biến đổi của đối số."

                "Kiểu tham số phải là một mảng một chiều duy nhất."
             */


            double totalPrice = CheckOut(3.99, 5.75, 15, 7, 8, 9.999);

            Console.WriteLine(totalPrice);



            //exception handling ⚠️

            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            // exception = lỗi xảy ra trong quá trình thực thi
            // try     = thử một số mã được coi là "nguy hiểm"
            // catch   = bắt và xử lý ngoại lệ khi chúng xảy ra
            // finally = luôn thực thi bất kể ngoại lệ có bị bắt hay không




            Console.ReadKey();
        }

        // viết một phương thức
        static void singHappyBirthday()
        {
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday to you!!!");
            Console.WriteLine("Happy birthday Happy birthday!!!");
            Console.WriteLine("Happy birthday to you!!!");
        }

        // vì hàm trên kia là có truyền đối số nên phải khi truyền vào phải báo cáo là nó có kiểu dữ liệu gì và tên nó là gì
        // Đây là đối số: String myNameis
        static void sayHello(String myNameis)
        {
            Console.WriteLine("                  ");
            Console.WriteLine("Hello" + myNameis);
            Console.WriteLine("How it's going" + myNameis);
            Console.WriteLine("Okay!!!");
            Console.WriteLine("Bye!!!");
        }

        static void howOldAreYou(String myNameis, int myAgeis)
        {
            Console.WriteLine("                  ");
            Console.WriteLine("Hello" + myNameis);
            Console.WriteLine("How old are you?");
            Console.WriteLine("Oh you are" + myAgeis);
            Console.WriteLine("Bye!!!");
        }

        // chú ý: khi dữ liệu trả về kiểu gì thì void đó nên thay đổi thành kiểu dữ liệu mà nó sẽ trả về,
        //Bạn có thể thấy static void đã phải chuyển thành static double, để phù hợp hơn với kiểu dữ liệu trả về. 
        static double Multiply( double xxxx, double yyyy)
        {
            double zzzz = xxxx * yyyy;
            return zzzz;
        }

        // sẽ sử dụng kiến thức overloading cho phép 2 phương thức trùng nhau nhưng khác đối số truyền vào
        static double Multiply(double xxxx, double yyyy, double oooo)
        {
            double zzzzz = xxxx * yyyy * oooo;
            return zzzzz;
        }

        //bài params keywords.
        //Vẫn áp dụng overloading vừa học, ta sẽ thấy nhược điểm, chính vì vậy ta sẽ dùng params để thay thế
        static double CheckOut(double a)
        {
            return a;
        }
        static double CheckOut(double a, double b)
        {
            return a + b;
        }

        static double CheckOut(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CheckOut(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }

        static double CheckOut(double a, double b, double c, double d, double e)
        {
            return a + b + c + d + e;
        }

        // cải tiến

        /*
         params trong C# được sử dụng để khai báo một tham số phương thức có thể nhận một số lượng đối số biến. 
         Trong trường hợp này, tham số prices có thể nhận một số lượng đối số double biến. 
         Điều này có nghĩa là bạn có thể gọi phương thức CheckOut() với bất kỳ số lượng đối số double nào, 
         và nó sẽ cộng tất cả các giá lại với nhau.
         */
        static double CheckOut(params double[] prices)
        {
            //totalPrice này sẽ khác với totalPrice kia tại nó nằm 2 static khác nhau 
            double totalPrice = 0;
            foreach(double price in prices)
            {
                totalPrice += price;
            }
            return totalPrice;
        }

    }
}