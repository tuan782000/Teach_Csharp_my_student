using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Doc
    {
        static void Main(string[] args)
        {
            //exception handling ⚠️

            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            // exception = lỗi xảy ra trong quá trình thực thi 
            // try     = thử một số mã được coi là "nguy hiểm" 
            // catch   = bắt và xử lý ngoại lệ khi chúng xảy ra 
            // finally = luôn thực thi bất kể ngoại lệ có bị bắt hay không

            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            } catch(FormatException e)
            {
                Console.WriteLine("Enter only number please!!!");
            } catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            } catch (Exception e)
            {
                Console.WriteLine("Some thing went wrong!!!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!!!");
            }


            // conditional operator = used in conditional assignment if a condition is true/false
            // toán tử 3 ngôi = được sử dụng trong phép gán điều kiện nếu điều kiện đúng/sai 

            //(condition) ? x : y (điều kiện) ? x : y

            double temperature = 20;
            String message;

            //nạp vào biến giá trị // nếu điều kiện true thì chạy ? và false thì chày vào :
            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);


            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            // string nội suy = cho phép chúng ta chèn các biến vào một chuỗi văn bản
            //                  đặt tiền tố cho một chuỗi văn bản với $
            //                  {} là các chỗ dành sẵn


            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            Console.WriteLine($"Hello{firstName} {lastName}"); //
            Console.WriteLine($"You are {age,-10} old."); // cách ở phía sau age 10 dấu cách



            // multidimensional arrays: mảng nhiều chiều

            // Xây dựng mảng đa chiều
            // Cần liệt kê các kiểu dữ liệu của cái này là gì
            //

            String[,] parkingLot = { 
                { "Mustang", "F-150", "Explore" }, 
                { "Corvette", "Camaro", "Silverado" }, 
                { "Corolla", "Camry", "Rav4" } 
            };


            parkingLot[0, 2] = "Fusion"; // hàng vị trí index 0 cột vị trí index 2 rơi vào explore thay thế thành Fusion
            parkingLot[2, 0] = "Tacoma"; // hàng index 2 cột index 0 là Corolla thay thế thành Tacoma
            parkingLot[1, 1] = "BMW"; // hàng index 1 vị trí index 1 Camaro thay thế thành BMW

            //foreach (String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            // Cũng có thể dùng vòng for 

            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for(int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }
            // Đoạn vòng lặp for for giúp vẽ bảng
            // sắp xếp thành 
            /*
                 "Mustang", "F-150", "Explore" , 
                 "Corvette", "Camaro", "Silverado" , 
                 "Corolla", "Camry", "Rav4"  
             
             */




            //classes 📦

            // class = A bundle of related code.
            //         Can be used as a blueprint to create objects (OOP)

            //          Một bó mã liên quan.
            //          Có thể được sử dụng làm bản thiết kế để tạo đối tượng (OOP)

            // class nhóm các chức năng code thành 1 class hiểu đại khái vậy
            // Ví dụ class Math chứa các phép toán cộng trừ nhân chia.


            //Gọi class Messages ở Messages.cs qua
            Messages.Hello();
            Messages.Wating();
            Messages.Bye();


            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            //          Một thể hiện của một class
            //          Một class có thể được sử dụng làm bản thiết kế để tạo các đối tượng (OOP)
            //          các đối tượng có thể có các trường & phương thức (đặc điểm & hành động)



            // sử dụng class Human (thực thể human đã được khai báo)
            //tên của class ____ tên viết thường = new ___ Tên của class
            Human human1 = new Human();
            /*
             Đoạn code Human human1 = new Human(); đang sử dụng lớp Human để tạo một đối tượng mới có tên là human1. 
             Từ khóa new được sử dụng để tạo một đối tượng mới của lớp Human. Tên của đối tượng mới là human1.
             */

            human1.name = "Rick";
            human1.age = 65;

            //này là phương thức ()
            human1.Eat();
            human1.Sleep();


            //có thể tạo ra human thứ 2
            Human human2 = new Human();


            human2.name = "Morty";
            human2.age = 16;

            //này là phương thức ()
            human2.Eat();
            human2.Sleep();



            //constructors 👷 Hàm khởi tạo

            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            // constructor = Là 1 phương thức đặt biệt trong 1 class
            //               tên khá tương tự class name
            //               Có thể được sử dụng để gán đối số cho các trường khi tạo một đối tượng


            // sau khi khai báo class và dùng cả constructor xong thì mình sử dụng

            //Car car1 = new Car(trong này là truyền đối số vào);
            Car car1 = new Car("Mercedes", "G-63", 2021, "black");
            Car car2 = new Car("Porche", "991", 2021, "white");

            car1.Drive();
            car2.Drive();




            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object



            //overloaded constructors 🍕

            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");



            //inheritance 👪 Kế thừa

            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            // kế thừa = 1 hoặc nhiều class child nhận các trường, phương thức, v.v. từ một cha chung (từ cha mẹ của chúng)


            Plane plane = new Plane();
            Bycicle bycicle = new Bycicle();
            Boat boat = new Boat();

            //khi kế thừa từ thực thể vehicle thì có thể sử dụng được tất cả thuộc tính hay phương thức thực thể
            // Nhưng nếu mà trùng thuộc tính hay phương thức thì nó phải ưu tiên chính nó hơn là kế thừa
            //Plane
            Console.WriteLine(plane.Speed);
            Console.WriteLine(plane.Wheels);
            plane.go();

            //bycicle
            Console.WriteLine(bycicle.Speed);
            Console.WriteLine(bycicle.Wheels);
            bycicle.go();


            //boat
            Console.WriteLine(boat.Speed);
            Console.WriteLine(boat.Wheels);
            boat.go();



            // abstract classes =  modifier that indicates missing components or incomplete implementation
            //                     modifier chỉ ra các thành phần bị thiếu hoặc triển khai không đầy đủ


            Dog dog = new Dog();
            Bird bird = new Bird();
            Fish fish = new Fish();
            // Animal animal = new Animal(); //can't create a animal object








            // array of objects

            //Country[] worlds = new Country[3];

            //Country country1 = new Country("Viet Nam");
            //Country country2 = new Country("Singapore");
            //Country country3 = new Country("American");

            //worlds[0] = country1;
            //worlds[1] = country2;
            //worlds[2] = country3;


            /*Console.WriteLine(worlds[0].name);*/ //kết quả Viet Nam
            /*Console.WriteLine(worlds[1].name);*/ //kết quả Singapore
            /*Console.WriteLine(worlds[2].name);*/ //kết quả American


            Country[] worlds = { new Country("Viet Nam"), new Country("Singapore"), new Country("American") };


            foreach (Country country in worlds)
            {
                Console.WriteLine(country.name);
            }




            // objects as arguments 🧳









            Console.ReadKey();
        }
    }

    //object
    class Human
    {
        //đặc điểm characteristics
        // cẩn thận khi dùng public tại vì không phải thông tin nào cũng được ở trạng thái này
        // vì để thuận tiện cho việc gọi sử dụng thì để public
        public String name;
        public int age;

        //hành động actions
        public void Eat()
        {
            Console.WriteLine(name + "is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + "is sleeping");
        }
    }

    class Car
    {
        String model;
        String make;
        int year;
        String color;

        //này là hàm khởi tạo
        public Car(String model, String make, int year, String color)
        {
            this.model = model;
            this.make = make;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model + " and " + year + color);
        }
    }

    //overloading constructor cũng cùng method nhưng truyền thêm các đối số khác vào thêm
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }


    // inheritance 

    class Vehicle
    {
        public int Speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is running");
        }


    }

    class Plane:Vehicle
    {
        public int Wheels = 4;

    }
    class Bycicle:Vehicle
    {
        public int Wheels = 2;
    }
    class Boat:Vehicle
    {
        public int Wheels = 0;
    }


    // abstract classes
    abstract class Animal
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

    }
    class Dog : Animal
    {
        public int legs = 4;
        int maxSpeed = 30;
    }
    class Bird : Animal
    {
        public int legs = 2;
        int maxSpeed = 10;
    }
    class Fish : Animal
    {
        public int legs = 0;
        int maxSpeed = 5;
    }

    class Country
    {
        public String name;

        public Country(String name)
        {
            this.name = name;
        }
    }
}
