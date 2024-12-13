const name = document.querySelector(".name");
const btn = document.querySelector("button");

btn.addEventListener("click", function() {
    name.style.color = "blue";
})

function changeColor(color) {
    name.style.color = color;
}