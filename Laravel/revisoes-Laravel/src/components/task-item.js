import { setTask } from "../store/tasks";


function render({task}) {

    const li = document.createElement('li')

    const checkbox= document.createElement('input')

    checkbox.setAttribute("type", 'checkbox');
    checkbox.addEventListener('click', (e) =>{
        task.isCompleted = !task.isCompleted
        setTask(task)

        const toggleCheckTaskItem = new CustomEvent('toggleCheckTaskItem',{
            detail: {
                task
            }
        });

        setTask(task)
    })

    if(task.isCompleted) checkbox.setAttribute('checked', "")


    li.append(checkbox)

    const span = document.createElement('span')
    span.textContent = task.title
    li.append(span)

    return li
}

export {render as renderTaskItem}