$(document).ready(() => {

    $(".searchBtn").click(() => {
        let searchInput = $(".searchInput").val();
        let searchCategory = $(".searchCategory option:selected").val();

        if (searchInput.length >= 1) {
            fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
                .then(Response => {
                    return Response.text
                })
                .then(data => {
                    $(".searchList").html(data);
                })
        }
    })



    $(".searchInput").keyup(function () {
        let inputVal = $(this).val();

        if (inputVal.length <= 0) {
            $(".searchList").html('');
        }
        else {
            fetch("http://localhost:23790/Shop/Search/?search=" + inputVal)
                .then(response => {
                    if (response.ok) {
                        console.log('Okey');
                        return response.text()
                    }
                })
                .then(data => {
                    $("#searcPar").html(data);
                })
        }





    })

}