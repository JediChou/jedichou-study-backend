/* file name: kx-scala-pg53.scala 
   description: class's field has default setter and getter
   from: Kuai Xue Scala, page 50-51
*/

/* create */
class Person { var age = 0 }
val fred = new Person()

/* output instance field's default value */
println("default value: " + fred.age)

/* change the field's value and output */
fred.age = 21
println("after change the value is: " + fred.age)

// ===================================================
// summary:
// ===================================================
// 1. var foo: scala auto generate getter and setter
// 2. val foo: scala auto generate getter
// 3. you can define (or modify) foo and foo_= method
// 4. you can define (or modify) foo
// ===================================================
