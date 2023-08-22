import { Component, OnInit } from '@angular/core';
import { Product } from 'src/Model/Product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit{

  ngOnInit(): void {
    this.getProducts();
  }
   products!: Product[];
 
   //constructor()
  //  {
  //   this.products = [
  //     new Product(1, 'Memory Card', 500),
  //     new Product(2, 'Pen Drive', 750),
  //     new Product(3, 'Power Bank', 100)
  // ];
  //  }
  //  public getProducts()
  //  {
  //   return this.products;
  //  }
  public getProducts() {
    
    this.products = [
        new Product(1, 'Memory Card', 500),
        new Product(2, 'Pen Drive', 750),
        new Product(3, 'Power Bank', 100)
    ]
    return this.products;
}
public getProduct(id: number) {
    let products:Product[]=this.getProducts();
    return products.find(p => p.productID==id);
}

}
