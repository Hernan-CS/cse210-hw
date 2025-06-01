using System.Collections.Generic;
using System.Text;

public class Order
{
    /* Encapsulation application */
    private List<Product> _products;
    private Customer _customer;

    /* Constructor */
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    /* Method to add products to the list previously created */
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    /* Method to calculate the final price of the order by adding a shipping cost if the user lives in USA or not */
    public double GetTotalPrice()
    {
        double total = 0;
        /* Iterate through the variables*/
        foreach (Product product in _products)
        {
            /* Constantly add each value and store it in the "total" variable */
            total += product.GetTotalCost();
        }

        /* Add a shipping cost if it lives in USA or not, we know this after using the 
        method IsInUSA() within the customer class which in turn it is in the Address class */
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    /* Method to create a packing label and return it */
    public string GetPackingLabel()
    {
        /* Set the value of the variable 'label' */
        string label = "-- Packing Label: --\n";
        /* Iterate */
        foreach (Product product in _products)
        {
            /* Add what is returned from the method GetPackingLabel() and put everything together in a new line */
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    /* Method to return the format of how the shipping label is going to be shown */
    public string GetShippingLabel()
    {
        return $"-- Shipping Label: --\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
