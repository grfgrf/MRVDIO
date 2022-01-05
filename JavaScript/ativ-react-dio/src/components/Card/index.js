import { useState } from 'react';
import Button from '../Button';
import Item from '../Item';

const Card = () => {

    const [valor, setValor] = useState(0)
    
    function Adicionar(){
        setValor(valor + 1)
    }

    function Diminuir(){
        if(valor>=1){
            setValor(valor - 1)
        }
    }
    
    return(
    <div className="card">
    <div className="card-header">
      Featured
    </div>
    <div className="card-body">
    <Button
        className="btn btn-success"
        onClick={Adicionar}
    >
        +
    </Button>
    <Button
        className="btn btn-danger"
        onClick={Diminuir}
    >
        -
    </Button>
     
     <p><Item>{valor} Itens</Item>
     
     </p>
    </div>
</div>
    )
}
export default Card;