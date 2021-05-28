

document.getElementById("searchbtn").onclick = search;
function search(){
    window.location.href = "https://localhost:5001/anime/search?animeName="+ document.getElementById("searchname").value;
}