let rawGetParameters = window.location.search.substr(1).split("&");
var getParameters = [];

rawGetParameters.forEach(rawGetParameter => {

    if (rawGetParameter.indexOf('=') >= 0)
    {
        getParameters.push({
            name : rawGetParameter.substring(0, rawGetParameter.indexOf('=')),
            value: rawGetParameter.substring(rawGetParameter.indexOf('=') + 1, rawGetParameter.length)
        });
    }
    else
    {
        getParameters.push({
            name : rawGetParameter,
            value: true
        });
    }
});

function openModalsInGetParameters()
{
    getParameters.forEach(getParameter => {
        if (getParameter.name == "open-modal")
        {
            document.getElementById(getParameter.value).classList.add("opened");
        }
    });
}



window.addEventListener('load', () => {

    //PEGANDO OS DATA-MODEL-OPEN
    document.querySelectorAll("*[data-modal-open]").forEach(e => {

        //Pega o valor do atributo
        let idModal = e.getAttribute("data-modal-open");

        //Pegando o elemento através do ID
        let modal = document.getElementById(idModal);

        //Verificando se o modal existe
        if (!modal)
        {
            throw `O modal com id ${idModal} não foi encontrado`;
        }

        e.addEventListener('click', () =>{
            modal.classList.toggle("opened");
        });

    });

    //PEGANDO O DATA MODEL AUTOCLOSE
    document.querySelectorAll(".modal[data-modal-autoclose]").forEach(e => {
        e.addEventListener('click', (event) => {
            if(e !== event.target) {
                return;
            }

            e.classList.remove("opened");
        });
    });

    openModalsInGetParameters();
});