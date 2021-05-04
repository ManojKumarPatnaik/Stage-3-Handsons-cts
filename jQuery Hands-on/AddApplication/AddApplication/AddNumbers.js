function add_two_number(){
    $("#result").val("");
            var a=$("#firstnumber").val();
            var b=$("#secondnumber").val();
            if(a=="" || b==""){
                $("#failure").html("<font color='red'>Pls.Enter the Values</font>")
            }
            else{
            var result=parseInt(a)+parseInt(b);
           
            $("#result").val(result);
            $("#failure").html("<font color='green'>"+result+"</font>");
            }
}