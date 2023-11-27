import React from 'react';
import {Link} from "react-router-dom";
import styles from './layout.module.scss'

const NavBar = () => {
    return (
        <div className={styles.navBar}>
            <div className={styles.wrap}>
                <Link to="/">Scientist Activity</Link>
            </div>
        </div>
    )
}

export const Layout = (props) => {
    return (
        <div>
            <NavBar/>
            {props.children}
        </div>
    );
}
