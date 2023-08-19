window.onscroll = () => {scrollButton()};

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

function closeNewsRead(e) {
    let id = e.dataset.id;
    document.getElementById(id).style.display = "none";
    document.body.style.overflow = "auto";
}

function openNewsRead(d) {
    let id = d.dataset.id;
    document.getElementById(id).style.display = "block";
    document.body.style.overflow = "hidden";
}

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

/* Demo Script */

const list = document.querySelectorAll(".spt");
const demoText = document.querySelector(".demoText");

list.forEach((item) => {
    item.addEventListener("click", (e) => {
        const id = item.dataset.id;
        const span = e.target.querySelector(".span");
        const activeSpan = document.querySelector(".spd");

        activeSpan.classList.remove("spd");
        span.classList.add("spd");
        if (id === "expert") demoText.textContent = "Talk to an expert";
        if (id === "demo") demoText.textContent = "Request a demo";
        if (id === "support") demoText.textContent = "Technical Support";
    })
})

/* Policy Script */

const aLinks = document.querySelectorAll(".privacy a");
const topButton = document.querySelector(".bTop");

aLinks.forEach((link) => {
    link.addEventListener("click", (e) => {
        e.preventDefault();
        const id = e.currentTarget.getAttribute("href").slice(1);
        const element = document.getElementById(id);
        let position = element.offsetTop;
        window.scrollTo({
            left:0,
            top:position - 10,
        })
    })
})

scrollButton = () => {
    if(document.documentElement.scrollTop > 650)
        topButton.classList.add("show");
    else
        topButton.classList.remove("show");
}

/*Product Script*/

const modules = [
    {
        title : "LITE",
        img : "assets/images/Products/Lite.png",
        desc : "Geared towards large practices, Genesys Health Management Information System is an ERP like solution that automates processes across all functional areas and departments.",
        feature : {
            "Patient Management" : [
                "Registration","Appointment Scheduling/Mgt"
            ],
            "Nurse Workbench" : [
                "Patient Triaging","Nursing Services","Immunization","Antenatal & delivery suite"
            ],
            "Inpatient Suite" : [
                "General Menu","Labour Menu","New Born","Antenatal Menu","Nursing Initial Assessment","Finalize"
            ],
            "Doctor Workbench" : [
                "GP Templates (i.e system review, physical assessments, gynecology history, family & social history)","Obstetric & Gynecology","Newborn examination template","CPOE"
            ],
            "Billing/Finance" : [
                "Automated billing & payment receipt","Corporate profile management (i.e partnership and insurance)"
            ],
            "Pharmacy" : [
                "Medication vetting & dispensing","Retail pharmacy"
            ],
            "Laboratory" : [
                "Basic sample collection & result entry","Retail laboratory"
            ],
            "Radiology" : [
                "Image upload & result entry"
            ],
            "Inventory/Store" : [
                "Inventory management"
            ],
            "Manager Dashboard" : [
                "Basic reports","Audit trail"
            ],
            "Queue Management" : [
                "Queue Management"
            ]
        }
    },
    {
        title : "MIDI",
        img : "assets/images/Products/MIDI.png",
        desc : "Geared towards large practices, Genesys Health Management Information System is an ERP like solution that automates processes across all functional areas and departments.",
        feature : {
            "Patient Management" : [
                "Registration","Appointment Scheduling/Mgt"
            ],
            "Nurse Workbench" : [
                "Patient Triaging","Nursing Services","Immunization","Antenatal & delivery suite"
            ],
            "Inpatient Suite" : [
                "General Menu","Labour Menu","New Born","Antenatal Menu","Nursing Initial Assessment","Finalize","Surgery"
            ],
            "Doctor Workbench" : [
                "GP Templates (i.e system review, physical assessments, gynecology history, family & social history)","Dental template","EENT template","Ophthalmology examination template","Optometry examination template","Dermatology Template","Obstetric & Gynecology","Newborn examination template","Mental examination template","Physiotherapy Examination template","Theatre booking & Surgery","CPOE"
            ],
            "Billing/Finance" : [
                "Automated billing & payment receipt","Corporate profile management (i.e partnership and insurance)"
            ],
            "Pharmacy" : [
                "Medication vetting & dispensing","Retail pharmacy"
            ],
            "Laboratory": [
                "Basic sample collection & result entry","Advanced laboratory workflow","Retail laboratory"
            ],
            "Radiology" : [
                "Image upload & result entry","Retail radiology"
            ],
            "Inventory/Store" : [
                "Inventory management"
            ],
            "Manager Dashboard": [
                "Basic reports","Audit trail","Report builder","Advanced custom built report"
            ],
            "Queue Management": [
                "Queue Management"
            ],
            Others : [
                "Teleconsultation","Patient self-service app"
            ],
            Services : [
                "On-premise training","Hand-holding"
            ]
        }
    },
    {
        title : "ERP",
        img : "assets/images/Products/ERP.png",
        desc : "Geared towards large practices, Genesys Health Management Information System is an ERP like solution that automates processes across all functional areas and departments.",
        feature : {
            "Patient Management" : [
                "Registration","Appointment Scheduling/Mgt"
            ],
            "Nurse Workbench" : [
                "Patient Triaging","Nursing Services","Immunization","Antenatal & delivery suite"
            ],
            "Inpatient Suite" : [
                "General Menu","Labour Menu","New Born","Antenatal Menu","Nursing Initial Assessment","Finalize","Accident & Emergency (A&E)","Intensive Care Unit (ICU)","Surgery"
            ],
            "Doctor Workbench" : [
                "GP Templates (i.e system review, physical assessments, gynecology history, family & social history)","Dental template","Neruo spinal template","EENT template","Ophthalmology examination template","Optometry examination template","Dermatology Template","Obstetric & Gynecology","Newborn examination template","Mental examination template","Audiology examination template","Physiotherapy Examination template","Theatre booking & Surgery","ICU","CPOE"
            ],
            "Billing/Finance" : [
                "Automated billing & payment receipt","Corporate profile management (i.e partnership and insurance)"
            ],
            "Pharmacy" : [
                "Medication vetting & dispensing","Retail pharmacy"
            ],
            "Laboratory" : [
                "Basic sample collection & result entry","Advanced laboratory workflow","Retail laboratory"
            ],
            "Radiology" : [
                "Image upload & result entry","Retail radiology"
            ],
            "Inventory/Store" : [
                "Inventory management","Procurement management"
            ],
            "Manager Dashboard" : [
                "Basic reports","Graphics dashboard","Audit trail","Report builder","Advanced custom built report"
            ],
            "Queue Management" : [
                "Queue Management"
            ],
            Others : [
                "Customization option","Multi location","Teleconsultation","Patient self-service app"
            ],
            Services : [
                "Requirement gathering & process re-engineering","On-premise training","Hand-holding"
            ]
        }
    }
]

const productDisplay = document.querySelector(".productDisplay");
const fList = document.querySelector(".fList");
const DetailsCnt = document.querySelector(".DetailsCnt");
let number = 0;

let moduleINumber = 1;

window.addEventListener("DOMContentLoaded", function (){
    /* let displayModule = modules.map(function (item){
        if (item === modules[1])
        {
            return `
            <div class="productCard active rounded shadow bg-body" data-id="feature" data-title="Genesys ${item.title}" data-item="${number++}">
                <img src=${item.img} alt="">
                <h3>Genesys ${item.title}</h3>
                <p>
                    ${item.desc}
                </p>
            </div>
            `;
        }
        return `
            <div class="productCard rounded shadow bg-body" data-id="feature" data-title="Genesys ${item.title}" data-item="${number++}">
                <img src=${item.img} alt="">
                <h3>Genesys ${item.title}</h3>
                <p>
                    ${item.desc}
                </p>
            </div>
        `;
    }).join("");
    
    productDisplay.innerHTML = displayModule; */


    /* let list = Object.keys(modules[moduleINumber].feature);
    let displayModuleList = list.map(function (item){
        if (item === list[0])
            return `<li class="featureItem active" data-name="${item}">${item}</li>`;
        return `<li class="featureItem" data-name="${item}">${item}</li>`;
    }).join("");

    fList.innerHTML = displayModuleList; */

    /* let details = modules[moduleINumber].feature["Patient Management"];
    let displayModuleDetails = details.map(function (item){
        return `
        <div class="featureItemDetails">
            <img src="assets/images/Products/up.png" alt="">
            <div>
                <h4>${item}</h4>
                <p>
                    Curabitur egestas consequat lorem, vel fermentum augue porta id. Aliquam lobortis magna neque, gravida consequat velit venenatis at.
                </p>
            </div>
        </div>
        `;
    }).join("");

    DetailsCnt.innerHTML = displayModuleDetails */;
});

// const productCard = document.querySelectorAll(".productCard");
// const moduleTitle = document.querySelector(".featureItemDetailsCnt h3");
let featureItem = document.querySelectorAll(".module-item");
let featureItems = document.querySelectorAll(".feature-item");


// productCard.forEach((item) => {
//     item.addEventListener("click", () => {
//         const activeCard = document.querySelector(".productDisplay .active");
//         const id = item.dataset.id;
//         const title = item.dataset.title;
//         moduleINumber = item.dataset.item;
//         activeCard.classList.remove("active");
//         item.classList.add("active");

//         const element = document.getElementById(id);
//         let position = element.offsetTop;
//         window.scrollTo({
//             left:0,
//             top:position,
//         })

//         moduleTitle.textContent = `${title}`;

//         let list = Object.keys(modules[moduleINumber].feature);
//         let displayNewModuleList = list.map(function (item){
//             if (item === list[0])
//                 return `<li class="featureItem active" data-name="${item}">${item}</li>`;
//             return `<li class="featureItem" data-name="${item}">${item}</li>`;
//         }).join("");
    
//         //fList.innerHTML = displayNewModuleList;
//     });
// });

/* featureItem.forEach((item) => {
    item.addEventListener("click", ()=>{
        let activeFeature = document.querySelector(".module-list .active");
        let element = document.getElementById("title");
        let name = item.dataset.name;
        console.log(name);

        let details = modules[moduleINumber].feature[name];
        let displayModuleDetails = details.map(function (item){
            return `
            <div class="featureItemDetails">
                <img src="assets/images/Products/up.png" alt="">
                <div>
                    <h4>${item}</h4>
                    <p>
                        Curabitur egestas consequat lorem, vel fermentum augue porta id. Aliquam lobortis magna neque, gravida consequat velit venenatis at.
                    </p>
                </div>
            </div>
            `;
        }).join("");

        DetailsCnt.innerHTML = displayModuleDetails;

        activeFeature.classList.remove("active");
        item.classList.add("active");

        let position = element.offsetTop;
        window.scrollTo({
            left:0,
            top:position,
        })
    })
}) */

featureItem.forEach((item) => {
    item.addEventListener("click", ()=>{
        let ElementId = item.dataset.name;
        let activeFeature = document.querySelector(".module-list .active");
        let activeItems = document.querySelectorAll(".online");

        console.log(ElementId);
        activeFeature.classList.remove("active");
        item.classList.add("active");

        activeItems.forEach((y) => {
            y.classList.remove("online");
        })

        featureItems.forEach((x) => {
            if (x.classList.contains(ElementId)) {
                x.classList.add("online");
            }
        })
    })
})


const moduleItem = document.querySelectorAll(".moduleItem");

moduleItem.forEach((item) => {
    item.addEventListener("click", ()=>{
        item.classList.toggle("active");
    })
})


//About

function scrollL() {
    var arrowLeft = document.querySelector(".flexpp");
    arrowLeft.scrollBy(-250, 0);
}

function scrollR() {
    var arrowRight = document.querySelector(".flexpp");
    arrowRight.scrollBy(250, 0)
}

function aboutTestimonySlide() {
    var move = document.querySelector(".aboutTest");
    move.scrollBy(420, 0);
}

setInterval(aboutTestimonySlide, 5000);

//Product

let priceButton = document.querySelectorAll(".comparisonPage .button .btn");

priceButton.forEach((item) => {
    item.addEventListener("click", ()=> {
        let activeButton = document.querySelector(".comparisonPage .button .act");
        let activePrice = document.querySelectorAll(".showCost")
        let bottonId = item.dataset.id;
        let priceBlock = document.querySelectorAll("."+bottonId);
        activeButton.classList.remove("act");
        item.classList.add("act");

        activePrice.forEach((e) => {
            e.classList.remove("showCost");
        })
        priceBlock.forEach((i) => {
            i.classList.add("showCost");
        })
    })
})

function scrollU() {
    var arrowLeft = document.querySelector(".productDisplay");
    arrowLeft.scrollBy(0, -340);
}

function scrollD() {
    var arrowRight = document.querySelector(".productDisplay");
    arrowRight.scrollBy(0, 340)
}

//Home Image Slider

const form = document.getElementById('newsletter-form');
const successModal = document.getElementById('successModal');
const emailInput = document.getElementById('EMAIL');

form.addEventListener('submit', function(event) {
    event.preventDefault();

    setTimeout(() => {
        showSuccessModal();
        submitForm();
        resetForm();
    }, 1000);
});

function showSuccessModal() {
    successModal.style.display = "flex";

    setTimeout(() => {
        hideSuccessModal();
    }, 3000);
}

function hideSuccessModal() {
    successModal.style.display = "none";
}

function resetForm() {
    emailInput.value = '';
}

function submitForm(){
    form.submit();
}

const imgContainer = document.querySelector('.inner-img-container');
const slides = imgContainer.getElementsByTagName('img');
var i = 0;
    
function nextSlide()
{
    slides[i].classList.remove('activeMainImage');
    i = (i + 1) % slides.length;
    slides[i].classList.add('activeMainImage');
}

const box = document.getElementById("testi-cap");

/* function test() {
    console.log((box.offsetWidth + 47));
    console.log(box.scrollLeft);
} */
/* function leftScroll(x){
    x.scrollBy(-350, 0);
}

function rightScroll(x){
    x.scrollBy(350, 0);
} */

function testimonySlide() {
    var move = document.querySelector(".testi-cap");

    // if ((box.offsetWidth + 47) - box.scrollLeft === 0)
    // {
    //     move.scrollBy(-350, 0);
    //     console.log("The End!");
    // }

    move.scrollBy(420, 0);
/*
    while ((box.offsetWidth + 47) > box.scrollLeft) {
        rightScroll(move);
    }
    if ((box.offsetWidth + 47) - box.scrollLeft === 0)
    {
        box.scrollLeft = 0;
    } */
}

setInterval(nextSlide, 5000);
setInterval(testimonySlide, 5000);

