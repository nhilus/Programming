import { renderTaskItem } from "./task-item.js"
import { getTasks } from "./tasks.js"

function render() {
    
    const ul = document.createElement('ul')
    
    function rerender() {
    document.addEventListener('tasksChanged', (e)=>{
        const task = getTasks()
        task.forEach(task =>{
            ul.append(renderTaskItem({task}))
        })
      })
    }
}
render()

export {render as renderTaskList}