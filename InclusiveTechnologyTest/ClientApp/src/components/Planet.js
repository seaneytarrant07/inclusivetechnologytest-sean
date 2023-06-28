

const Planet = (props) => {
    
    return (
        <div className="planet-wrapper col">
            <div className="planet">
                <h1>{props.name}</h1>
                <p>{props.description}</p>
                <div className="facts">
                    <p><b>Facts:</b></p>
                    <ul>
                        <li>Distance from the Sun(10<sup>6</sup>km): {props.distance}</li>
                        <li>Mass(10<sup>24</sup>kg): {props.mass}</li>
                        <li>Diameter(km): {props.diameter}</li>
                    </ul>
                </div>
            </div>
        </div>
    )
}

export default Planet;