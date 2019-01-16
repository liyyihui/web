function clickdivbackground(id, arrt) {
    for (var i = 0 ; i < arrt.length; i++) {
        console.log(arrt[i])
        if (arrt[i] == id) {
            document.getElementById(id).style.background = "red"
           
        } else {
            document.getElementById(arrt[i]).style.background = "#4682B4"
            document.getElementById(id).style.color = "#ffffff"
               }
    }
}