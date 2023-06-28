using InclusiveTechnologyTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace InclusiveTechnologyTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Name="Mercury", Distance="57.9", Mass="0.330", Diameter="4879", Description="Mercury the smallest planet in our solar system and closest to the Sun is only slightly larger than Earth's Moon. Mercury is the fastest planet, zipping around the Sun every 88 Earth days." },
            new ItemModel{Name="Venus", Distance="108.2", Mass="4.87", Diameter="12,104", Description="Venus spins slowly in the opposite direction from most planets. A thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system." },
            new ItemModel{Name="Earth", Distance="149.6", Mass="5.97", Diameter="12,756", Description="Earth our home planet is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface." },
            new ItemModel{Name="Mars", Distance="228.0", Mass="0.642", Diameter="6792", Description="Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere." },
            new ItemModel{Name="Jupiter", Distance="778.5", Mass="1898", Diameter="142,984", Description="Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red spot is a centuries-old storm bigger than Earth." },
            new ItemModel{Name="Saturn", Distance="1432.0", Mass="568", Diameter="120,536", Description="Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's. " },
            new ItemModel{Name="Uranus", Distance="2867.0", Mass="86.8", Diameter="51,118", Description="Uranus seventh planet from the Sun rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side." },
            new ItemModel{Name="Neptune", Distance="4515.0", Mass="102", Diameter="49,528", Description="Neptune the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations. " },
        };

        [HttpGet]

        public ItemModel[] Get()
        {
            ItemModel[] items = Items.ToArray();
            return items;
        }
    }
}
