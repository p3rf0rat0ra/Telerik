function GetMax(args) {
    var numbers = (args + '').split(' ').map(Number);
    max = numbers.reduce(function(a, b) {
        return a >= b ? a : b;
    });
    console.log(max);
}
