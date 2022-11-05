let car = { Brand: "BMW", Model: "M7", Color: "Blue", Year: 2021 }

// console.log(car.Brand + " " + car.Model + " " + car.Color + " " + car.Year);
let counter = 0;
let cars =
    [
        { Brand: "BMW", Model: "M7", Color: "Blue", Year: 2021 },
        { Brand: "Mercedes", Model: "C Class", Color: "White", Year: 2008 },
        { Brand: "BMW", Model: "X5", Color: "Black", Year: 2017 },
        { Brand: "Ford", Model: "Mustang", Color: "Red", Year: 2003 },
        { Brand: "Toyoto", Model: "Prius", Color: "Grey", Year: 2015 },
        { Brand: "BMW", Model: "F10", Color: "Pink", Year: 2022 }
    ]

// for (let i = 0; i < cars.length; i++) {
//     if (cars[i].Year >= 2015) {
//         counter++
//         console.log(cars[i].Brand + "-" + cars[i].Model + "-" + cars[i].Color + "-" + cars[i].Year);
//     }
// }

for (let i = 0; i < cars.length; i++) {
    if (cars[i].Brand == "BMW") {
        counter++
        console.log(cars[i].Brand + "-" + cars[i].Model + "-" + cars[i].Color + "-" + cars[i].Year);
    }
}


console.log(counter);


let students =
    [
        { Name: "Eli", Surname: "Eliyev", Age: 19, Point: 98 },
        { Name: "VEli", Surname: "Eliyev", Age: 19, Point: 44 },
        { Name: "DEli", Surname: "Eliyev", Age: 19, Point: 49 },
        { Name: "YEli", Surname: "Eliyev", Age: 19, Point: 65 },
        { Name: "TEli", Surname: "Eliyev", Age: 19, Point: 78 },
        { Name: "KEli", Surname: "Eliyev", Age: 19, Point: 100 }
    ]


for (let i = 0; i < students.length; i++) {
    if (students[i].Point >= 65) {
        console.log(students[i].Name + " " + students[i].Surname + " " + students[i].Point);
    }
}