

function Item(id, name, price) {
  
    const self = this;
    self.Id = ko.observable(id);
    self.Name = ko.observable(name);
    self.Price = ko.observable(price);
    
};

function viewModel() {
    const self = this;

    self.items = ko.observableArray([]);
    self.items2 = ko.observableArray([]);





    $.ajax({
            type: "GET",
            url: "/api/products",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                var Data = ko.utils.arrayMap(data, function (item) {
                    return new Item(item.id, item.name, item.price);
                });
                self.items(Data);

               // self.items(data);
        },
            error: function (error,a,b) {
               //  alert(error.status + "<--and--> " + error.statusText);
                console.log(a);
                console.log(b);
                console.log(error)
                    
            }
        });
    

    Data1 = new Item(this.Id) 
    self.save = function (Data1) {
        var Id = Data1.Id
 
        $.ajax({
            type: "GET",
            url: "/api/products/" + Id,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    self.items2(data); //Put the response in ObservableArray  
                    // GetSingleProducts();
                },
                error: function (error) {
                    alert(error.status + "<--and--> " + error.statusText);
                }
            });
        
    }
};


$(document).ready(function () {
    ko.applyBindings(new viewModel());
});