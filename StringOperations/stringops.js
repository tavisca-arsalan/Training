String.prototype.Concat = function (stringTwo)
{
    var stringOne = this;
    
    var concatenatedString = [stringOne.length + stringTwo.length];

    if (stringOne.length < stringTwo.length)
    {
        var limit = stringTwo.length;
    }
    else
    {
        var limit = stringOne.length;
    }
   
    for (var index = 0; index < limit; index++) {
        if (index < stringOne.length)
        {
            concatenatedString[index] = stringOne.charAt(index);
        }
        if (index < stringTwo.length)
            concatenatedString[index + stringTwo.length] = stringTwo.charAt(index);
    }

    concatenatedString = concatenatedString.join("");
    // console.log(concatenatedString);
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