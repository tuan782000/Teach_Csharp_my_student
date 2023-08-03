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



            //number guessing game 







            //ẩn các thông tin không cần thiết, chỉ hiện code chạy, lưu ý luôn đặt cuối cùng, tránh ngăn chặn code chạy
            Console.ReadKey();
        }
    }
}