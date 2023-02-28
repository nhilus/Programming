import  {addContact} from "../presenter/contactListPresenter.js";


const contactForm= document.querySelector('form')


function setForm({_id= -1, fullName='', phoneNumber='',email= '',}){
    contactForm._id.value = _id
    contactForm.fullName.value = fullName
    contactForm.phoneNumber.value = phoneNumber
    contactForm.email.value = email
}

function registerFormOnSubmit(){
    contactForm.addEventListener('submit',(e)=>{
        e.preventDefault()
        try{
            const rawList = [...e.target.children]
            const inputsList= rawList.filter(input => {return input.name !==''})

            const formObject= {}

            for( const input of inputsList) {
                formObject[input.name] = input.value
            }

            addContact(formObject)

            for(const input of inputsList) {
                input.value = ''
            }
        }
        catch(error){
            console.error(error)
        }
    })
}

export {setForm,registerFormOnSubmit}