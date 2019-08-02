let remote;
let tivi;
let videoHtml;
let statusHtml;

function channels(valueButton) {
    remote.id = valueButton;
    console.log(tivi.status);
    if (tivi.status === true) {
        videoHtml.src = remote.convertChannels(tivi);
    }
}

function status() {
    console.log(tivi.status);
    if (tivi.status === true) {
        videoHtml.style.display = "none";
        statusHtml.style.display = "block";
        tivi.status = false;
        location.reload();
    } else {
        tivi.status = true;
        statusHtml.style.display = "none";
        videoHtml.style.display = "block";
    }
}

window.onload = function() {
    tivi = new Tivi();
    remote = new Remote();
    videoHtml = document.getElementById("video");
    statusHtml = document.getElementById("channels");
}