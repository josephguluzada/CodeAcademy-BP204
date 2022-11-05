// var number = 23;

// if (number % 2 == 0) {
//     console.log(number + " ededi cutdur");
// }
// else {
//     console.log(number + " ededi tekdir");
// }

// var age = 17;

// if (age > 18) {
//     console.log("qebul olundunuz");
// }
// else if (age == 18) {
//     console.log("Tebrikler,qebul oldunuz");
// }
// else {
//     console.log("Yasiniz catmir");
// }

var choice = 5;

switch (choice) {
    case 1:
        console.log("Bazar ertesi");
        break;
    case 2:
        console.log("Cersenbe Axsami");
        break;
    case 3:
        console.log("Cersenbe");
        break;
    case 4:
        console.log("Cume Axsami");
        break;
    case 5:
        console.log("Cume");
        break;
    case 6:
    case 7:
        console.log("Hefte sonu");
        break;
    default:
        console.log("Bele hefte gunu yoxdur");
        break;
}