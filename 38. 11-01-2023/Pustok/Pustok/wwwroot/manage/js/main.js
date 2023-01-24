let deleteBtns = document.querySelectorAll(".delete-button");

deleteBtns.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href");
    let id = btn.getAttribute("data-id");

    Swal.fire({
        title: 'Əminsiniz mi?',
        text: "Geri qaytara bilməyəcəksiniz!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Bəli, sil onu!',
        cancelButtonText: 'Xeyr!'
    }).then((result) => {
        if (result.isConfirmed) {
            fetch(url)
                .then(response => {
                    if (response.status == 200) {
                        window.location.reload(true);
                    } else {
                        alert(`${id}-li data yoxdur!`)
                    }
                })
        } 
    })

}))


let deleteImageBtns = document.querySelectorAll(".delete-image-button");

deleteImageBtns.forEach(btn => btn.addEventListener("click", function () {
    btn.parentElement.remove()
}))