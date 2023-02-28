const tasks = [
    {
        id: 1,
        title:'Task 1',
        isCompleted: true,
    },
    {
        id: 2,
        title:'Task 2',
        isCompleted: false,
    },
    {
        id: 3,
        title:'Task 3',
        isCompleted: false,
    }
]

function getTasks() {
    return tasks
}

function setTask(newTask) {
    let task = tasks.find(currentTask => currentTask.id === newTask.id)
    task = newTask

    const tasksChanged = new Event('tasksChanged')
    document.dispatchEvent(tasksChanged)

}

export {getTasks, setTask}