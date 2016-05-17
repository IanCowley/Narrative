Narrative is a simple BDD framework, which gives you a simple Given When Then syntax.  It is not opinionated, it's basic.  Very basic...

I wrote this because there was nothing else about that did what I needed and to be fair

**Installation**
Via NuGet

```
Install-Package Narrative
```

**Example Of Usage**

```
[Test]
public void CreatingACustomerAndAProduct()
{
    var customer = new Customer();
	var product = new Product();

    Story
    	.Given("I have a customer with basic information", () => this.PopulateCustomer(customer))
    	.And("I have product A", () => this.PopulateProduct(product, name: A))
        .When("Save customer", () => this.SaveCustomer(customer))
        .And("Save product" () => this.SaveProduct(product))
        .And("Attach product to customer", () => this.AttachProductToCustomer(customer, product))
        .Then("Customer Exists", () => this.CustomerExists(customer))
        .And("Product Exists", () => this.ProductExists(product))
        .And("Customer is Attached to product", () => this.CustomerIsAttachedToProduct(customer, product))
        .Start();
}
```
*Pull requests are welcome by the way.*"# Narrative" 
