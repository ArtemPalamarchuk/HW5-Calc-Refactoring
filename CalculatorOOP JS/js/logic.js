function summ(a, b) {
	if(typeof a !== 'number' || typeof b !== 'number'){
        return 'не число';
    }
	a = ((a * 1000000000) + (b * 1000000000))/1000000000;
	return a;
}
function minus(a, b) {
	if(typeof a !== 'number' || typeof b !== 'number'){
        return 'не число';
    }
	a = ((a * 1000000000) - (b * 1000000000))/1000000000;
	return a;
}	
function divide(a, b) {
	if(typeof a !== 'number' || typeof b !== 'number'){
        return 'не число';
    }
	a = ((a * 1000000000) / (b * 1000000000));
	return a; 
}
function multiply(a, b) {
	if(typeof a !== 'number' || typeof b !== 'number'){
        return 'не число';
    }
	a = ((a * 1000000) * (b * 1000))/1000000000;
	return a;
}

let logic = {
	summ,
	minus,
	divide,
	multiply,
};