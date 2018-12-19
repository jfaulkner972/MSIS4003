// When the user scrolls the page, execute myFunction 
window.onscroll = function () { myFunction() };

// Get the header
var header = document.getElementById("navbar");

// Get the offset position of the navbar
var sticky = header.offsetTop;

// Add the sticky class to the header when you reach its scroll position. Remove "sticky" when you leave the scroll position
function myFunction() {
    if (window.pageYOffset >= sticky) {
        header.classList.add("sticky");
    } else {
        header.classList.remove("sticky");
    }
}

//window.onscroll = function () { scrollFunction() };
//function scrollFunction() {
//    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
//        document.getElementById("navbar").style.top = "0px";
//    }
//    else {
//        document.getElementById("navbar").style.top = "10px";
//    }
//}