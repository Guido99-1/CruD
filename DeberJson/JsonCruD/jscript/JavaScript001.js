var app1 = new Vue({
    el: '#app',                                 //enlazar el elemento
    data: {    // definie cual es el elemto a manipular
        newEntry: {
            name: '',
            amount: 0,
            paid: false
        },
        items: [
            { name: 'Servicio de Intenet', amount: 23, paid: false },
            { name: 'Servicio de Telefonía', amount: 9, paid: false },
            { name: 'Servicio de Agua', amount: 42, paid: false },
            { name: 'Servicio de Luz Electrica', amount: 11, paid: true }
        ]
    },
    methods: {
        remove(index) {
            // alert(index);
            //spl elimina un conjunto de datos
            this.items.splice(index, 1);
        },
        add() {// ecma script -> para que funcione en todos los navegadores
            //this.newEntry.amount=parseFloat(this.newEntry.amount);
            //this.items.push(this.newEntry);
            this.items.push({
                name: this.newEntry.name,
                amount: parseFloat(this.newEntry.amount),
                paid: false
            });
            this.newEntry.name = ''; // encerar el atributo nombre y amount
            this.newEntry.amount = 0;
        },
        changePaid(item) {
            item.paid = !item.paid
        },
        totalAmount(option) {
            var total = this.items.reduce(function (a, b) {
                switch (option) {
                    case 0: return a + (!b.paid ? b.amount : 0);
                    case 1: return a + (b.paid ? b.amount : 0);
                    case 2: return a + b.amount;
                }
                return a + b.amount;
            }, 0);
            return total.toFixed(2);
        }
    }
});