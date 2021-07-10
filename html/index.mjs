
'use struct'



document.querySelector('#field').addEventListener('mousedown', event=>{
  const pos = {};
  pos.x = event.x - document.querySelector('#field').getBoundingClientRect().x;
  pos.y = event.y - document.querySelector('#field').getBoundingClientRect().y;
  for(let target of document.querySelectorAll('#field .card[data-moving]')) target.dataset.moving = '';
  let target = void 0;
  for(var dom of document.querySelectorAll('#field .card')){
    const y = dom.getBoundingClientRect().y - document.querySelector('#field').getBoundingClientRect().y;
    const x = dom.getBoundingClientRect().x - document.querySelector('#field').getBoundingClientRect().x;
    if(y <= pos.y && pos.y <= y + 260 && x <= pos.x && pos.x <= x + 200)
      target = {node: dom, posstr: JSON.stringify({x: pos.x - x, y: pos.y - y})};
  }
  if(target){
    target.node.dataset.moving = target.posstr;
    document.querySelector('#field').appendChild(target.node);
    target = void 0;
  }
});

document.querySelector('#field').addEventListener('mousemove', event=>{
  const targets = document.querySelectorAll('#field .card[data-moving]');
  for(let target of targets)
    if(target && target.dataset.moving){
      const pos = JSON.parse(target.dataset.moving);
      const mouse = {};
      mouse.x = event.x - document.querySelector('#field').getBoundingClientRect().x;
      mouse.y = event.y - document.querySelector('#field').getBoundingClientRect().y;
      target.style.transform = 'translate(' + (mouse.x - pos.x) + 'px,' + (mouse.y - pos.y) + 'px)';
      break;
    }
});

document.querySelector('#field').addEventListener('mouseup', event=>{
  const targets = document.querySelectorAll('#field .card[data-moving]');
  for(let target of targets) target.dataset.moving = '';
});
