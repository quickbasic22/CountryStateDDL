$(document).ready(function ()
{

    $("#CountryId").change(function ()
    {
        var countryId = $(this).val();
        $.ajax({
            type: "Post",
            url: "/Test/GetStateList?CountryId=" + countryId,
            contentType: "html",
            success: function (response)
            {
                $("#StateId").empty();
                $("#StateId").append(response);
            }
        });
    });

    
});