/*News Script*/
let items = document.querySelectorAll(".nav-item");
items.forEach(item => {
    item.addEventListener("click", () => {
        const viewId = item.dataset.id;
        const viewItem = document.getElementById(viewId);
        const currentViewItem = document.querySelector('.show');
        const activeLink = document.querySelector('.active');
        activeLink.classList.remove("active");
        item.classList.add("active");
        currentViewItem.classList.remove("show");
        viewItem.classList.add("show");
    })
})

/*Index-Question Script*/
const questions = document.querySelectorAll(".question");

questions.forEach((question) => {
    const btn = question.querySelector(".question-btn");
    btn.addEventListener('click', ()=> {
        questions.forEach((item)=>{
            if(item !== question)
            {
                item.classList.remove("showText");
            }
        });

        question.classList.toggle("showText");
    })
})