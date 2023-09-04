# Teach_Csharp_my_student

## OOP - Object Oriented Programming

Hướng Đối Tượng. Suy nghĩ mọi thứ đều là đối tượng, hướng đối tượng mô phỏng mọi thứ trong đời thực thành đối tượng khi được đưa vào code.

Ví dụ: Ngôi nhà, con người, đồ vật xung quanh điện thoại, máy tính,...

1 Đối tượng thì nó có Tính chất và Hành động.

Ví dụ: 

Về tính chất, con người chúng ta có tính chất để thể hiện các thông số: chiều cao, cân nặng, màu da, màu tóc, giới tính ,... Nói chung mô tả 1 đối tượng cụ thể.

Về hành động, con người chúng ta có các hành động: ăn, ngủ, đi chơi, đi làm, các hoạt động thường ngày,... Mô tả cái hành vi mà con người hành động

## Trong lập trình "tính chất" được coi là Properties/Fields

## Trong lập trình "hành động" được coi là Methods/Functions

Làm nên 1 ứng dụng, nó sẽ giải quyết các nhu cầu thực tiễn, việc của lập trình viên chuyển hóa nó thành các cái đối tượng vào bên trong code

### Tính trừu tượng  (Abstraction)

Bản chất của "Abstraction" là làm đơn giản đi 1 thực thể nào đó.
Chẳng hạn như làm 1 app quản lý con người. Bắt đầu lấy số liệu và trừu tượng hóa nó trong ứng dụng, thì việc mô tả hết tất cả tính chất (Properties/Fields) của con người là không cần thiết.
Chúng ta chỉ nên mô tả một vài cái tính chất (Properties/Fields) đặc trưng.
Chẳng hạn quản lý nhân sự thì cần các Properties/Fields sau: Tên, tuổi, địa chỉ, sdt, ngày tháng năm sinh,...

Để mô hình hóa 1 nhân vật hoặc object nào đó vào trong ứng dụng thì sẽ có 1 thứ gọi là Class, mọi ngôn ngữ OOP đều có Class cả

Class là Prototype (là 1 khuôn mẫu) Để tạo ra 1 thứ gì đó.

Ví dụ: Đang làm bánh. Muốn bánh hình gì thì ta phải có khuôn hình đó. Sau đó thì lấy khuôn đó ịn 1 phát thì bánh nó có hình dạng đó.

Rút ra kết luận: 

Object là 1 thực thể
Class là 1 khuôn mẫu để tạo ra thực thể đó.

Circle circle = new Circle(5);


Kết luận: "Còn trừu tượng hóa là có 2 thứ là abstract class và interface."


## Tính Đóng gói (Encapsulation)

Khi đã đưa được 1 Object vào trong code rồi thì suy nghĩ đến 1 chuyện. Đâu phải mọi thông tin của đối tượng đều show ra cho người khác xem.
Ví dụ: Muốn biết về chiều cao hay cân nặng của mình, thì phải hỏi mình. Sẽ có những cái thông tin mình sẽ để người ta coi, có những thông tin phải hỏi mình xong mình mới quyết định có trả lời cho hay không.

Từ cái đó mới sinh ra thằng Tính Đóng gói (Encapsulation).

Đóng gói là Đóng một thứ gì đó vào trong một hộp. Người ngoài sẽ không biết bên trong cái hộp chứa cái gì? Nếu mà bạn không muốn cho người ta biết bên trong có cái gì thì dùng băng keo dán lại thui.

Trong lập trình thể hiện được cái đó là Access modifiers

private
public
internal
protected
package
...

Không muốn nói ra cho người khác biết thì dùng private, điều này làm cho các class khác không thể lấy ra được.

Có 1 số BACKPLACTICE thí dụ thuộc tính Properties/Fields nó private xong rồi tạo ra các function public là get, set
Đó là cách các nơi khác có thể tác động vào để thay đổi thông số object đó

=> Tóm lại bản chất của Tính đóng gói là cho người ta thấy những thông tin mà bạn muốn cho người ta thấy về cái object này, các thông tin bạn không muốn cho người ta thấy thì bạn sẽ giấu nó đi

Kết luận:
Đóng gói là cách mình che đậy một số thông tin thông qua các access modifier như public, protected, private, default. 
  - Public: Các thuộc tính và phương thức được khai báo là public có thể truy cập được từ bên trong lớp và bên ngoài lớp.
  - Default: huộc tính default có thể truy cập được từ bên trong lớp và từ các lớp trong cùng một gói (package).
  - Protected: Các thuộc tính và phương thức được khai báo là protected có thể truy cập được từ bên trong lớp và từ các lớp con của lớp đó.
  - Private: Các thuộc tính và phương thức được khai báo là private chỉ có thể truy cập được từ bên trong lớp.


## Kế thừa (Inheritance) (extend) 

Kế thừa rất dễ hình dung, những gì chúng ta học được thì bản chất là chúng ta được kế thừa từ cha ông chúng ta. Trong lập trình tính kế thừa cũng như vậy.

Trong lập trình ta biết có class, thì nó có chia ra class cha người ta hay gọi là Super hay còn biết đến base class hay còn gọi người đầu tiên trong gia phả. (Class cha/base/super)

Ví dụ: 
Class Person tưởng tượng nó là 1 class cha. Class cha này có các thuộc tính, tính chất Properties/Fields:  name, age, dob || và methods/functions : goToWork() 
Class Developer tưởng tượng là nó 1 class con. Class con này kế thừa từ cha thì Class con này có đầy đủ các tính chất Properties/Fields và methods/functions từ thằng cha
Tương tự cho Manager và Designer. 

Kết luận:
Kế thừa là lớp con (class child) sẽ có hết những thuộc tính và phương thức của lớp cha (class parent) thông qua từ khóa extend (kế thừa) 

## Đa hình (Polymorphism)

Poly - Many
Morphism - forms

Many forms: nhiều hình thái khác nhau, đa hình đa dạng

các Polymorphism làm 1 việc là các class con từ kế thừa overwrite lại các function mà kế thừa lại từ class cha/super

ở ví dụ trên các class developer, designer, Manager sẽ có các hàm goToWork() kế thừa lại từ class cha Person. Nhưng developer, designer, Manager tính chất công việc 3 thằng này khác nhau.
Chính vì vậy bên trong hàm goToWork() mỗi thằng sẽ cần viết lại overwrite lại theo cách riêng của mỗi developer, designer, Manager

Kết luận:
Đa hình là có 2 khái niệm là overriding và overloading.
Overriding là mình sẽ thay đổi lại hành vi xử lý của 1 method.
Còn overloading là có nhiều method cùng tên nhưng khác số lượng, thứ tự các parameter.
