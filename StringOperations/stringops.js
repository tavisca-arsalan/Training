String.prototype.Concat = function (stringTwo)

{   
   

        var firstString = this;
        var concatenatedString;
        
        for (var i = 0; i < arguments.length; i++) {
            var secondString = arguments[i];

            concatenatedString = [firstString.length + secondString.length];
            var temp = firstString.length;
            if (temp < secondString.length)
                temp = secondString.length;
            for (var index = 0; index < temp; index++) {
                if (index < firstString.length)
                { concatenatedString[index] = firstString.charAt(index); }
                if (index < secondString.length)
                    concatenatedString[index + firstString.length] = secondString.charAt(index);
            }
            concatenatedString = concatenatedString.join("");
                firstString = concatenatedString;
            }
        

            
            return concatenatedString;
        }



  
    




String.prototype.Substring = function (startIndex, endIndex) {
    if (startIndex < 0 || endIndex < 0) {
        document.write("Invalid range specified for substring.");
        return;
    }
    var substring = "";
    for (var index = startIndex ; index < endIndex; index++)
    {
        substring = substring + (this[index]);
    }

    return substring;
}