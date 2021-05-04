$(document).ready(
    function(){
        $('#btn').click(
            
            function(){
                var toAdd = $('input[id=txt]').val();
                if(toAdd==="")
                {
                    alert("Enter task details!!");
                }
                else
                {
                 $('#para1').append("<br>"+toAdd);
                 
                }
            });
        });
    