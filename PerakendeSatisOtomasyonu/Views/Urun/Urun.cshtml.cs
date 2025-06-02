using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PerakendeSatisOtomasyonu.Models;
using System.Threading;

@Model IEnumerable<PerakendeSatisOtomasyonu . Models.Product>

<h2> Ürün Listesi</h2>

<table class= "table" >
    <thead>
        <tr>
            < th > Id </ th >
            < th > Ad </ th >
            < th > Fiyat </ th >
        </ tr >
    </ thead >
    < tbody >
    @foreach(var urun in Model)
    {
        <tr>
            <td> @urun.Id </td>
            <td> @urun.Ad </td>
            <td> @urun.Fiyat </td>
        </tr>
    }
    </ tbody >
</ table >
