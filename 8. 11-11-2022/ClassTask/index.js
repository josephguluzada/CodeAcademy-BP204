let place = document.querySelector(".container .row")

axios.get("https://api.tvmaze.com/shows")
    .then(res => {
        console.log(res.data);
        for (let i = 0; i < res.data.length; i++) {
            place.innerHTML += `<div class="col-3">
            <div class="card" style="width: 18rem;">
                <img src="${res.data[i].image.medium}"
                    class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">${res.data[i].name}</h5>
                    <p class="card-text">Premiere: ${res.data[i].premiered}</p>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Imdb rating: ${res.data[i].rating.average}</li>
                    <li class="list-group-item">Genre: ${res.data[i].genres[0]}</li>
                    <li class="list-group-item">Language: ${res.data[i].language}</li>
                </ul>
                <div class="card-body d-flex">
                    <a href="${res.data[i].officialSite}" class="card-link btn btn-primary">Go to website</a>
                    <a href="${res.data[i].officialSite}" class="card-link btn btn-success">Go to detail</a>
                </div>
            </div>`
        }
    })