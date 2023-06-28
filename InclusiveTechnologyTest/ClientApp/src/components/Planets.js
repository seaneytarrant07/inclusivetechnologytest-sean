import React, { useState, useEffect } from 'react';
import Planet from './Planet';

const Planets = () => {
    const [items, setItems] = useState([]);

    const [selected, updatedSelected] = useState([]);
    const [active, setActive] = useState();
    const [bgImage, setBg] = useState("planetshero");


    //Fetch the planets items from Item Controller and return in a json format and update items array
    useEffect(() => {
        fetch(`item`)
            .then((results) => {
                return results.json();
            })
            .then(data => {
                setItems(data);
            })
    }, [])


    //When a planet list item is clicked
    const planetClicked = (planet) => {
        updatedSelected(() => {
            return [planet]; //Update the selected state with the selected planet
        })

        setActive(planet.name); //update the active planet 
        setBg(planet.name.toLowerCase() + 'hero'); //update the background image with the active planet image
    }

    return (
        <div className="wrapper">
            <div className="row">
                <div className="list-wrapper col">
                    {
                        (items != null) ? //Only show if planets exist
                            items.map((item) => //List out all planets 
                                <div key={item.mass} className={`list-item${active == item.name ? " active" : ""}` } onClick={() => planetClicked(item)}>
                                    <h3>{item.name}</h3>
                                </div>
                            )
                            : <div>Loading...</div>
                    }
                </div>
                {
                    (selected != null) ? //Only show if a planet has been selected
                        selected.map((planet) => 
                            <Planet //Display the details of the selected planet
                                name={planet.name}
                                distance={planet.distance}
                                mass={planet.mass}
                                diameter={planet.diameter}
                                description={planet.description}
                            />
                        )
                        : ""
                }
                </div>
                <div className="bg-image" style={{ backgroundImage: `url(${'/images/' + bgImage + '.jpg' })` }}>
            </div>
        </div>
    )
}

export default Planets;