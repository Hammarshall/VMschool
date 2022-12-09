using System;

namespace VMschool.Interface;

public interface IVendingItem // all the functions that every VendingItem needs 
{
    public void Use();
    public void Description();
    public void Buy();
    public int Price();
    void ShowProductName();
}