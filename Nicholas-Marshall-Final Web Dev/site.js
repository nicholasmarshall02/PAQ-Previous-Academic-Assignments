function myValidate() {
	var isValid= true;
	var strErr = "";
	var fName = document.getElementById("txtFName").value;
	var email = document.getElementById("txtEmail").value;
	var pnumber = document.getElementById("txtPNumber").value;
	var price = document.getElementById("txtPrice").value;
	
	if(!fName.length) {
		isValid = false;
		strErr += "First Name can't be blank.<br />";
	}
	
	if(!email.length) {
		isValid= false;
		strErr += "Email can't be blank.<br />";
	}
	
	if(!pnumber.length) {
		isValid= false;
		strErr += "Email can't be blank.<br />";
	}
	
	if(!price.length) {
		isValid= false;
		strErr += "Email can't be blank.<br />";
	}
	
	var myOut = document.getElementById("output");
	if(isValid) {
		myPrint();
	} else { 
		myOut.innerHTML = "<p class='error'>" + strErr + "</p>";
	}
		
	function myPrint () {
			var myP ="<p>";
			myP+= "Name:" + fName +"<br />";
			myP+= "Email: <a href='mailto:" + email + "'>" + email + "</a><br />";
			myP+= "Phone Number:" + pnumber + "<br />";
			myP+= "Price:" + price +"<br />";
			myOut.innerHTML = myP + "</p>";
			
	}
	
	return false;
}


function init() {
	var myBtnGoB = document.getElementById("btnGoB");
	myBtnGoB.onclick = myValidate;
	
	var my2 =document.getElementById("inGoB");
	my2.onclick = myValidate;
	
	var myForm=document.getElementById("myForm");
	myForm.onsubmit = myValidate
}

window.onload = init;