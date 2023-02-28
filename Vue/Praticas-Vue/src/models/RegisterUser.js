export default class RegisterUser {
  constructor(user){
    if(!user) return
    this.name = user.name;
    this.email= user.email;
    this.phoneNumber= user.phoneNumber;
    this.textArea= user.textArea;
    this.image = user.image;
  }
}
