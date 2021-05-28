

document.getElementById("searchbtn").onclick = search;
function search(){
    window.location.href = "https://localhost:5001/anime/search?animeName="+ document.getElementById("searchname").value;
}


const addfav= async (id)=>{
    document.getElementById("popup").style.opacity = "1"
    await fetch("https://localhost:5001/users/addFav/1?animeid="+id)
    window.setTimeout(()=>{
        document.getElementById("popup").style.opacity = "0"
    },3000)
}

