import './style.css'
import { renderTaskList } from './src/components/tasks-list';

const app = document.querySelector('#app')

const component = [renderTaskList()]

component.forEach(element => {
  app.append(element)
});

document.addEventListener(toggleCheckTaskItem, (e)=>{
  render()
})


