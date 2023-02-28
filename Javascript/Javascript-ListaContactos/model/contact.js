class Contact{
    #_id
    #fullname
    #phone_Number
    #email

    constructor(props){
        const {_id=1, fullname, phone_Number,email}=props
        this.#_id=_id
        this.#fullname=fullname
        this.#phone_Number=phone_Number
        this.#email=email
    }

    get fullname(){
        return this.#fullname
    }
    get phone_Number(){
        return this.#phone_Number
    }

    get email(){
        return this.#email
    }

    get phone_Number(){
        return this.#phone_Number
    }

    get _id(){
        return this.#_id
    }

    set _id(value){
        this.#_id=value
    }
}

export {Contact}