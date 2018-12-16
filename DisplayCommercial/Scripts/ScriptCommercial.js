
//window.onload = addvertisment();
window.onload = companyinfo();

function companyinfo() {
    var comNum = document.getElementsByClassName('Commercial');
    for (var i = 0; i < comNum.length; i++) {
        comNum[i>.style.backgroundColor = "red";
        //divcolor();
    }
}
    $(document).ready(function () {
        $("#slideshow > div:gt(0)").hide();
        setInterval(function () {
            $('#slideshow > div:first')
                .fadeOut(1000)
                .next()
                .fadeIn(1000)
                .end()
                .appendTo('#slideshow');
        }, 5000);

    });
