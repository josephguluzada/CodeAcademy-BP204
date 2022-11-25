// fetch("https://jsonplaceholder.typicode.com/todos/5")
//     .then(response => response.json())
//     .then(data => console.log(data))


// fetch("https://api.tvmaze.com/shows/1")
//     .then(res => res.json())
//     .then(data => {
//         let img = document.createElement("img");

//         img.setAttribute("src", data.image.medium);


//         document.querySelector("body").appendChild(img)
//     })


// fetch("https://api.tvmaze.com/shows")
//     .then(res => res.json())
//     .then(datas => {
//         for (let i = 0; i < datas.length; i++) {
//             let img = document.createElement("img");
//             img.setAttribute("src", datas[i].image.medium);

//             document.querySelector("body").appendChild(img)
//         }
//     }).catch(err => console.log(err))

// AXIOS

// axios.get("https://api.tvmaze.com/shows")
//     .then(response => {
//         console.log(response);
//         for (let i = 0; i < response.data.length; i++) {
//             let img = document.createElement("img");
//             img.setAttribute("src", response.data[i].image.medium);

//             document.querySelector("body").appendChild(img)
//         }
//     })



// AJAX

// $.ajax({
//     method: "GET",
//     url: "https://api.tvmaze.com/shows",
//     type: JSON
// }).done(datas => {
//     for (let i = 0; i < datas.length; i++) {
//         let img = document.createElement("img");
//         img.setAttribute("src", datas[i].image.medium);

//         document.querySelector("body").appendChild(img)
//     }
// })






